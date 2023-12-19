using Microsoft.AspNetCore.Mvc;

namespace EnergyBackendWebsite.Controllers
{
    public class EnergyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
