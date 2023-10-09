using DotNet5MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotNet5MVC.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult GetProducts()
        {
            Product product = new Product();

            return View();
        }
    }
}
