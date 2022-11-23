using System;
using Killar.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Killar.Controllers
{
    public class CommentsController : Controller
    {

        private readonly ILogger<CommentsController> _logger;

        public CommentsController(ILogger<CommentsController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public IActionResult RegisterComment(Comments c)
        {
            Authentication.CheckLogin(this);
            CommentsService cs = new CommentsService();
            c.CommentDate = DateTime.Now; //data do comentário é o momento em que ele foi cadastrado
            cs.AddComment (c);
            return RedirectToAction("Comunity", "Users");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new { RequestId = System.Diagnostics.Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}