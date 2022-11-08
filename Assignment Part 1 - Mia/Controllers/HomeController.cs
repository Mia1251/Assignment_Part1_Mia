using Microsoft.AspNetCore.Mvc;

namespace Assignment_Part_1___Mia.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
