using System;
using Killar.Models;
using Microsoft.AspNetCore.Http;
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
                newPost.PostDate = DateTime.Now;
                ps.AddPost(newPost);

                return RedirectToAction("Comunity", "Users");

            }
            catch (Exception e)
            {

                _logger.LogError("Erro ao Cadastrar Post!" + e.Message);
                return RedirectToAction("Login", "Home");
            }

        }

        public IActionResult PostList(string filterType, string filter, string itemsPerPage, int numberOfPage, int currentPage)
        {
            Authentication.CheckLogin(this);
            Authentication.CheckIfUserIsAdministrator(this);

            PostsFilter filterPosts = null;

            if (!string.IsNullOrEmpty(filter))
            {
                filterPosts = new PostsFilter();
                filterPosts.Filter = filter;
                filterPosts.FilterType = filterType;
            }

            PostsService ps = new PostsService();

            ViewData["postsPerPage"] = (string.IsNullOrEmpty(itemsPerPage) ? 8 : Int32.Parse(itemsPerPage));

            ViewData["currentPage"] = (currentPage != 0 ? currentPage : 1);

            return View(ps.GetPostsFull(filterPosts));
        }

        public IActionResult PostEdit(int id)
        {
            try
            {

                Authentication.CheckLogin(this);

                Posts foundPost = new PostsService().GetPostDetail(id);
                return View(foundPost);

            }
            catch (Exception e)
            {

                _logger.LogError("Erro ao buscar Post para ser editado!" + e.Message);
                return RedirectToAction("Login", "Home");

            }

        }

        [HttpPost]
        public IActionResult PostEdit(Posts postEdit)
        {
            try
            {

                Authentication.CheckLogin(this);

                new PostsService().EditPost(postEdit);

                if (HttpContext.Session.GetInt32("type") == 0)
                {
                    return RedirectToAction("PostList");
                }
                else
                {
                    return RedirectToAction("Comunity", "Users");
                }

            }
            catch (Exception e)
            {

                _logger.LogError("Erro ao Editar Post!" + e.Message);
                return RedirectToAction("Login", "Home");

            }

        }

        public IActionResult PostDelete(int id)
        {

            try
            {

                Authentication.CheckLogin(this);

                PostsService ps = new PostsService();
                Posts foundPost = ps.GetPostDetail(id);

                return View(foundPost);

            }
            catch (Exception e)
            {

                _logger.LogError("Erro ao buscar Post a ser deletado!" + e.Message);
                return RedirectToAction("Login", "Home");

            }
        }

        [HttpPost]
        public IActionResult PostDelete(int id, string decision)
        {
            try
            {

                if (decision == "yes")
                {
                    Authentication.CheckLogin(this);

                    PostsService ps = new PostsService();
                    ps.DeletePost(id);
                }
                if (HttpContext.Session.GetInt32("type") == 0)
                {
                    return RedirectToAction("PostList");
                }
                else
                {
                    return RedirectToAction("Comunity", "Users");
                }


            }
            catch (Exception e)
            {

                _logger.LogError("Erro ao deletar o Post!" + e.Message);
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