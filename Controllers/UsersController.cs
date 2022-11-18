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
                    HttpContext.Session.Clear();
                    return RedirectToAction("Login", "Home");
                }

            }
            catch (Exception e)
            {
                _logger.LogError("Erro ao se Cadastrar!" + e.Message);
                return RedirectToAction("Index", "Home");
            }

        }

        public IActionResult UserList(string q, int pages =1)
        {
            Authentication.CheckLogin(this);
            Authentication.CheckIfUserIsAdministrator(this);

            // Esse método só será utilizado por usuários administradores que obterão em formato de lista todos os usuários cadastrados.

            int usersPerPage = 8;

            UsersService us = new UsersService();
            if (q == null)
            {
                q = string.Empty;
            }

            int registersQuantity = us.CountRegister();
            ViewData["pageQuantity"] = (int)Math.Ceiling((double)registersQuantity / usersPerPage);
            ICollection<Users> userList = us.GetUsers(q, pages, usersPerPage);

            return View(userList);
        }

        public IActionResult UserEdit(int id)
        {

            try
            {

                Authentication.CheckLogin(this);
                Authentication.CheckIfUserIsAdministrator(this);
                Users UserFound = new UsersService().ListUser(id);

                return View(UserFound);

            }
            catch (Exception e)
            {
                _logger.LogError("Erro ao Buscar por Usuário a ser Editado !" + e.Message);
                return View();
            }

        }

        [HttpPost]
        public IActionResult UserEdit(Users editUser)
        {
            try
            {

                Authentication.CheckLogin(this);
                Authentication.CheckIfUserIsAdministrator(this);
                new UsersService().EditUser(editUser);

                return RedirectToAction("Index", "Home");

            }
            catch (Exception e)
            {
                _logger.LogError("Erro ao Editar Usuário !" + e.Message);
                return RedirectToAction("Index", "Home");
            }

        }

        public IActionResult UserProfileEdit(int id)
        {

            try
            {

                Authentication.CheckLogin(this);
                Users UserFound = new UsersService().ListUser(id);

                return View(UserFound);

            }
            catch (Exception e)
            {
                _logger.LogError("Erro ao Buscar por Usuário a ser Editado !" + e.Message);
                return View();
            }

        }

        [HttpPost]
        public IActionResult UserProfileEdit(Users editUser)
        {
            try
            {

                Authentication.CheckLogin(this);
                new UsersService().EditUserProfile(editUser);

                return RedirectToAction("UserProfile", "Users");

            }
            catch (Exception e)
            {
                _logger.LogError("Erro ao Editar Usuário !" + e.Message);
                return RedirectToAction("UserProfile", "Users");
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
                    Users FoundUser = us.SearchForId(id);

                    return View(FoundUser);

                }

            }
            catch (Exception e)
            {

                _logger.LogError("Erro ao Buscar por Usuário a ser Excluído !" + e.Message);
                return View();

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
                    case "Delete":
                        if (HttpContext.Session.GetInt32("type") == 0)
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
                return RedirectToAction("UserList", "Users");

            }

        }

        public IActionResult UserProfile()
        {
            try
            {
            
                Authentication.CheckLogin(this);
                UsersService ur = new UsersService();
                int IdUserSession = (int)HttpContext.Session.GetInt32("IdUser");
                List<Users> UserList = ur.ProfileUser(IdUserSession);

                return View(UserList);

            }
            catch (Exception e)
            {
                _logger.LogError("Erro ao Exibir o Perfil de Usuário !" + e.Message);
                return RedirectToAction("Login", "Home");
            }
        }

        public IActionResult Logout()
        {
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