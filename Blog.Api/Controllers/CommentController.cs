using Microsoft.AspNetCore.Mvc;

namespace Blog.Api.Controllers
{
    public class CommentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
