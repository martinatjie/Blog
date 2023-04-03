using Microsoft.AspNetCore.Mvc;

namespace Blog.Api.Controllers
{
    public class LikesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
