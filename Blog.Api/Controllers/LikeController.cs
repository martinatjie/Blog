using Microsoft.AspNetCore.Mvc;

namespace Blog.Api.Controllers
{
    public class LikeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
