using AnonymousBlog.Contracts;
using AnonymousBlog.Data.Models;
using AnonymousBlog.Data.ViewDataModels;
using Microsoft.AspNetCore.Mvc;

namespace AnonymousBlog.Controllers
{
    public class PostController : Controller
    {
        private readonly IPostService postService;

        public PostController(IPostService _postService)
        {
            postService = _postService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddPost(ViewData_Post post)
        {
            if (!ModelState.IsValid)
            {
                return View(post);
            }
            if (postService.AddPost(post))
            {
                return RedirectToAction("SuccessfulOperation");
            }

            return View(null);
        }

        
        public IActionResult DeletePost(int id)
        {
            if (id<=0)
            {
                return View(id);
            }
            if (postService.DeletePost(id))
            {
                return RedirectToAction("SuccessfulOperation");
            }

            return View(null);
        }

        public IActionResult ShowAllPosts()
        {
            List<Post> model = postService.GetAllPost();
            return View(model);
        }
        public IActionResult SuccessfulOperation()
        {
            return View();
        }

        
    }
}
