using EducationalApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EducationalApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Species()
        {
            return View();
        }

        public IActionResult Scissortail()
        {
            return View();
        }

        public IActionResult Achilles()
        {
            return View();
        }

        public IActionResult Rusty()
        {
            return View();
        }

        public IActionResult Grey()
        {
            return View();
        }

        public IActionResult Omura()
        {
            return View();
        }

        public IActionResult Bottlenose()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
