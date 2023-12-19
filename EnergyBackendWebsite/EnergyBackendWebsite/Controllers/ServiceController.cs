using Microsoft.AspNetCore.Mvc;

namespace EnergyBackendWebsite.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
