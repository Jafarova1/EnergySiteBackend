using Microsoft.AspNetCore.Mvc;

namespace EnergyBackendWebsite.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
