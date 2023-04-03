using Microsoft.AspNetCore.Mvc;

namespace Blog.Api.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
