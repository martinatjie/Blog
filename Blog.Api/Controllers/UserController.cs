using Microsoft.AspNetCore.Mvc;

namespace Blog.Api.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
