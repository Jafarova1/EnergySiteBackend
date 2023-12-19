using Microsoft.AspNetCore.Mvc;

namespace EnergyBackendWebsite.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
