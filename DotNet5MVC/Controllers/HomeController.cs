using Microsoft.AspNetCore.Mvc;

namespace DotNet5MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
