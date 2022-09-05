using BreakpointApp.Backoffice.ViewModels.Access;
using Microsoft.AspNetCore.Mvc;

namespace BreakpointApp.Backoffice.Controllers
{
    public class AccessController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return RedirectToAction("Login");
        }

        [HttpGet]
        public IActionResult Login(string returnUrl = "")
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            { 
                return View(model);
            }

            return View(model);
        }
    }
}
