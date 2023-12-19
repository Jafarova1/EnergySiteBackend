using Microsoft.AspNetCore.Mvc;

namespace EnergyBackendWebsite.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
