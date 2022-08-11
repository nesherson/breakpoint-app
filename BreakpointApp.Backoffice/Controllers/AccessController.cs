using Microsoft.AspNetCore.Mvc;

namespace BreakpointApp.Backoffice.Controllers
{
    public class AccessController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
