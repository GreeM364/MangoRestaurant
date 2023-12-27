using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace Mango.Web.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        { }

        public IActionResult Index()
        {
            return View();
        }

        [Authorize]
        public IActionResult Login()
        {
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Logout()
        {
            return SignOut("Cookies", "oidc");
        }
    }
}