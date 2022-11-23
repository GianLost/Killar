using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace Killar.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string login, string password)
        {

            try
            {

                if (Authentication.CheckLoginAndPassword(login, password, this)) // Verifica se login e senha estão de acordo com os dados do banco, se a verificação retornar verdadeiro estabelece uma sessão;
                {

                    ViewData["logged"] = "Bem Vindo, " + HttpContext.Session.GetString("login");

                    return View("Index");

                }
                else
                {
                    ViewData["ErrorLogin"] = "Usuário ou senha inválidos";

                    return View();
                }

            }
            catch (Exception e)
            {

                _logger.LogError("Erro ao Realizar Login!" + e.Message);
                return RedirectToAction("Login", "Home");

            }

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new { RequestId = System.Diagnostics.Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
