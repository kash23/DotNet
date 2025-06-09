using Microsoft.AspNetCore.Mvc;

namespace DotNet.Controllers
{
    public class AttributeController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("Users");
        }

        [Route("Users")]
        public IActionResult Users()
        {
            return View();
        }
    }
}
