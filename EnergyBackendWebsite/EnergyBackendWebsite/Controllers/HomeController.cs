using EnergyBackendWebsite.Data;
using EnergyBackendWebsite.Models;
using EnergyBackendWebsite.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace EnergyBackendWebsite.Controllers
{
    public class HomeController : Controller
    {
      private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
                
        }

        public async Task<IActionResult> Index()
        {
           List<Slider> sliders=await _context.Sliders.Where(m=>!m.SoftDelete).ToListAsync();
            About about=await _context.Abouts.Where(m => !m.SoftDelete).FirstOrDefaultAsync();

            HomeVM model = new()
            {
                Sliders = sliders,
                About=about
            };
            return View(model);
        }


    }
}