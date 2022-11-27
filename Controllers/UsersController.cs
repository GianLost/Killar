using System;
using System.Collections.Generic;
using Killar.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Killar.Controllers
{
    public class UsersController : Controller
    {
        private readonly ILogger<UsersController> _logger;

        public UsersController(ILogger<UsersController> logger)
        {
            _logger = logger;
        }

        public IActionResult RegisterUser()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegisterUser(Users newRegisterUser)
        {
            try
            {

                UsersService us = new UsersService();
                us.AddUser(newRegisterUser);

                // caso o Usuário que esteja criando o cadastro seja um administrador ele se manterá na mesma página após o cadastro. Caso contrário será redirecionado para a página de login.

                if (HttpContext.Session.GetInt32("type") == 0)
                {

                    return RedirectToAction("RegisterUser", "Users");
                }
                else
                {
                    return RedirectToAction("Login", "Home");
                }

            }
            catch (Exception e)
            {
                _logger.LogError("Erro ao se Cadastrar!" + e.Message);
                return RedirectToAction("Login", "Home");
            }

        }

        public IActionResult UserList(string q, int pages = 1)
        {
            Authentication.CheckLogin(this);
            Authentication.CheckIfUserIsAdministrator(this);

            // Esse método só será utilizado por usuários administradores que obterão em formato de lista todos os usuários cadastrados.

            int usersPerPage = 8; // definindo a quantidade de usuários exibidos por página

            UsersService us = new UsersService();

            if (q == null) // verifica se a busca da filtragem é nula, se verdadeiro atribui-se o valor como vazio;
            {
                q = string.Empty;
            }

            int registersQuantity = us.CountRegister(); // Método CountRegister retorna a quantidade de registros realizados;

            ViewData["pageQuantity"] = (int)Math.Ceiling((double)registersQuantity / usersPerPage); // Atriundo ao ViewData["pageQuantity"] através do método Math(), o valor total de páginas a serem apresentadas de acordo com o número total de usuários por página;

            ICollection<Users> userList = us.GetUsers(q, pages, usersPerPage); // Objeto de coleção de usuários que armazena os valores da busca feita pela filtragem, o número de páginas a serem apresentadas na paginação, e o número de usuários que serão listados por página para que os dados armazenados sejam utilizados como retorno;

            return View(userList);
        }

        public IActionResult UserEdit(int id)
        {

            try
            {

                Authentication.CheckLogin(this);
                Authentication.CheckIfUserIsAdministrator(this);

                Users UserFound = new UsersService().ListUser(id); // Objeto que busca pelo Id do usuário selecionado para edição (Válido apenas para Usuário admin);

                return View(UserFound);

            }
            catch (Exception e)
            {
                _logger.LogError("Erro ao Buscar por Usuário a ser Editado !" + e.Message);
                return RedirectToAction("Login", "Home");
            }

        }

        [HttpPost]
        public IActionResult UserEdit(Users editUser)
        {
            try
            {

                Authentication.CheckLogin(this);
                Authentication.CheckIfUserIsAdministrator(this);

                new UsersService().EditUser(editUser); // Chamada do método que modifica e sobrescreve os dados ao editar o usuário;

                return RedirectToAction("Index", "Home");

            }
            catch (Exception e)
            {
                _logger.LogError("Erro ao Editar Usuário !" + e.Message);
                return RedirectToAction("Login", "Home");
            }

        }

        public IActionResult UserProfileEdit(int id)
        {

            try
            {

                Authentication.CheckLogin(this);

                Users UserFound = new UsersService().ListUser(id); // Objeto que busca pelo Id do usuário selecionado para edição;

                return View(UserFound);

            }
            catch (Exception e)
            {
                _logger.LogError("Erro ao Buscar por Usuário a ser Editado !" + e.Message);
                return RedirectToAction("Login", "Home");
            }

        }

        [HttpPost]
        public IActionResult UserProfileEdit(Users editUser)
        {
            try
            {

                Authentication.CheckLogin(this);

                new UsersService().EditUserProfile(editUser); // Chamada do método que raliza as edições e sobrescreve os dados editados;

                return RedirectToAction("UserProfile", "Users");

            }
            catch (Exception e)
            {
                _logger.LogError("Erro ao Editar Usuário !" + e.Message);
                return RedirectToAction("Login", "Home");
            }

        }

        public IActionResult UserDelete(int id)
        {
            try
            {
                using (KillarContext dataBase = new KillarContext())
                {

                    Authentication.CheckLogin(this);

                    UsersService us = new UsersService();

                    Users FoundUser = us.SearchForId(id); // Busca pelo Id de usuário a ser excluído;

                    return View(FoundUser);

                }

            }
            catch (Exception e)
            {

                _logger.LogError("Erro ao Buscar por Usuário a ser Excluído !" + e.Message);
                return RedirectToAction("Login", "Home");

            }

        }

        [HttpPost]
        public IActionResult UserDelete(string decision, Users deleteuser)
        {

            try
            {

                Authentication.CheckLogin(this);

                UsersService us = new UsersService();

                switch (decision)
                {
                    // Verifica a opção escolhida pelo usuário e exclui caso a verificação retorne excluir, ou simplesmente redireciona novamente uma nova página de acordo com o nível de usuário se a verificação retornar cancelar;

                    case "Delete":

                        if (HttpContext.Session.GetInt32("type") == 0) // Tipo armazenado na sessão
                        {
                            us.DeleteUser(deleteuser.Id);
                            return RedirectToAction("UserList", "Users");
                        }
                        if (HttpContext.Session.GetInt32("type") == 1)
                        {
                            us.DeleteUser(deleteuser.Id);
                            HttpContext.Session.Clear();
                            return RedirectToAction("Index", "Home");
                        }

                        break;

                    case "Cancel":

                        if (HttpContext.Session.GetInt32("type") == 0)
                        {
                            return RedirectToAction("UserList", "Users");
                        }
                        if (HttpContext.Session.GetInt32("type") == 1)
                        {
                            return RedirectToAction("UserProfile", "Users");
                        }

                        break;
                }

                return View(deleteuser);
            }
            catch (Exception e)
            {
                _logger.LogError("Erro ao Excluir Usuário !" + e.Message);
                return RedirectToAction("Login", "Home");

            }

        }

        public IActionResult UserProfile()
        {
            try
            {

                Authentication.CheckLogin(this);

                UsersService us = new UsersService();

                int IdUserSession = (int)HttpContext.Session.GetInt32("IdUser");

                List<Users> UserList = us.ProfileUser(IdUserSession); // Faz a chamada do método de perfil do usuário que tem como parâmetro o Id do usuário na sessão. O valor da chamada é atribuído a uma lista de usuários;

                return View(UserList); // Retorna uma listagem dos dados de usuário cadastrados de acordo com o Id registrado na sessão

            }
            catch (Exception e)
            {
                _logger.LogError("Erro ao Exibir o Perfil de Usuário !" + e.Message);
                return RedirectToAction("Login", "Home");
            }
        }

        public IActionResult Comunity()
        {
            //Authentication.CheckLogin(this);
            PostsService ps = new PostsService();
            ICollection<Posts> postList = ps.GetPostsFullToComunity();
            return View(postList);
        }

        public IActionResult Logout()
        {
            // Encerra a sessão limpando os dados e redirecionando para página de login;

            HttpContext.Session.Clear();
            return RedirectToAction("Login", "Home");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new { RequestId = System.Diagnostics.Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}