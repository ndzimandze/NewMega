using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using STUDENT.Models;

namespace STUDENT.Controllers
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
           
               if (TempData.ContainsKey("UserName"))
            {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                ViewBag.UserName = TempData["UserName"].ToString();
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            }
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
        public IActionResult login()
        {
            return View();
        }
        public IActionResult SignUp()
        {
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }

        public IActionResult Privacy()
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
