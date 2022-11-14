using System;
using System.Diagnostics;
using Killar.Models;
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
            try{

                UserService us = new UserService();
                us.AddUser(newRegisterUser);
                ViewData["message"] = "Usuário Cadastrado com sucesso !";

                return RedirectToAction("Index", "Home");

            }catch (Exception e) {

                UserService us = new UserService();
                us.AddUser(newRegisterUser);
                ViewData["message"] = "Usuário Cadastrado com sucesso !";
                
                _logger.LogError("Erro ao se Cadastrar!" + e.Message);

                return RedirectToAction("Index", "Home");
            }
            
        }

        public IActionResult UserList()
        {
            Authentication.CheckIfUserIsAdministrator(this);
            return View(new UserService().ListUser());
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}