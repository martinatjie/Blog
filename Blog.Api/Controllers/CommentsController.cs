using Microsoft.AspNetCore.Mvc;

namespace Blog.Api.Controllers
{
    public class CommentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
