using System;
using Killar.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Killar.Controllers
{
    public class PostsController : Controller
    {
        private readonly ILogger<PostsController> _logger;

        public PostsController(ILogger<PostsController> logger)
        {
            _logger = logger;
        }

        public IActionResult RegisterPost()
        {
            Authentication.CheckLogin(this);
            return View();
        }

        [HttpPost]
        public IActionResult RegisterPost(Posts newPost)
        {
            try
            {

                Authentication.CheckLogin(this);
                PostsService ps = new PostsService();
                int newPostId = ps.AddPost(newPost);
                if (newPostId != 0)
                {
                    ViewData["messagePost"] = "Postagem realizada com sucesso";
                }
                else
                {
                    ViewData["messagePostError"] = "Falha na Postagem";
                }

                return RedirectToAction("PostList");

            }
            catch (Exception e)
            {

                _logger.LogError("Erro ao Cadastrar Post!" + e.Message);
                return RedirectToAction("RegisterPost");
            }

        }

        public IActionResult PostList(string filterType, string filter, string itemsPerPage, int numberOfPage, int currentPage)
        {
            Authentication.CheckLogin(this);

            PostsFilter filterPosts = null;
            if (!string.IsNullOrEmpty(filter))
            {
                filterPosts = new PostsFilter();
                filterPosts.Filter = filter;
                filterPosts.FilterType = filterType;
            }
            PostsService ps = new PostsService();

            ViewData["postsPerPage"] = (string.IsNullOrEmpty(itemsPerPage) ? 10 : Int32.Parse(itemsPerPage));

            ViewData["currentPage"] = (currentPage != 0 ? currentPage : 1);

            return View(ps.GetPostsFull(filterPosts));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new { RequestId = System.Diagnostics.Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}