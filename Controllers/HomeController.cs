using System.Diagnostics;
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

                if (Authentication.CheckLoginAndPassword(login, password, this))
                {
                    return RedirectToAction("Index");
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
                return View();

            }

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
