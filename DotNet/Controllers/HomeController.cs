using System.Diagnostics;
using System.Text.Json.Serialization;
using DotNet.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotNet.Controllers
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
            LINQControllercs.LINQ();
            return View();
        }

        public ActionResult Data()
        {
            return View();
        }

        public ContentResult get()
        {
            return Content(" wasted ");
        }

        public JsonResult json()
        {
            var user = new { name = "ak", age = 30 };
            return Json(user);
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
