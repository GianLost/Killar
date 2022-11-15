using System;
using System.Diagnostics;
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
                ViewData["message"] = "Usuário Cadastrado com sucesso !";

                return RedirectToAction("Index", "Home");

            }
            catch (Exception e)
            {

                UsersService us = new UsersService();
                us.AddUser(newRegisterUser);
                ViewData["message"] = "Usuário Cadastrado com sucesso !";

                _logger.LogError("Erro ao se Cadastrar!" + e.Message);

                return RedirectToAction("Index", "Home");
            }

        }

        public IActionResult UserList()
        {
            Authentication.CheckLogin(this);
            Authentication.CheckIfUserIsAdministrator(this);
            return View(new UsersService().ListUser());
        }

        public IActionResult UserEdit(int id)
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
        public IActionResult UserEdit(Users editUser)
        {
            try
            {

                Authentication.CheckLogin(this);
                new UsersService().EditUser(editUser);

                return RedirectToAction("Index", "Home");

            }
            catch (Exception e)
            {

                Authentication.CheckLogin(this);
                new UsersService().EditUser(editUser);

                _logger.LogError("Erro ao Editar Usuário !" + e.Message);

                return RedirectToAction("Index", "Home");

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

                if (decision == "Delete")
                {
                    us.DeleteUser(deleteuser.Id);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    return RedirectToAction("UserList", "Users");
                }

            }
            catch (Exception e)
            {
                _logger.LogError("Erro ao Excluir Usuário !" + e.Message);
                return RedirectToAction("UserList", "Users");  

            }

        }

        public IActionResult UserProfile()
        {
            return View();
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