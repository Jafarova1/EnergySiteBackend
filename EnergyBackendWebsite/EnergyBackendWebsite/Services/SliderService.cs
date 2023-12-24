using EnergyBackendWebsite.Data;
using EnergyBackendWebsite.Helpers.Extensions;
using EnergyBackendWebsite.Models;
using EnergyBackendWebsite.Services.Interfaces;
using EnergyBackendWebsite.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace EnergyBackendWebsite.Services
{
    public class SliderService : ISliderService
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public SliderService(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public async Task DeleteAsync(int id)
        {
            Slider slider = await _context.Sliders.Where(m => m.Id == id).FirstOrDefaultAsync();
            _context.Sliders.Remove(slider);
            await _context.SaveChangesAsync();

            string path = _env.GetFilePath("img", slider.Image);

            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }

        public async Task EditAsync(SliderEditVM slider)
        {
            string oldPath = _env.GetFilePath("img", slider.Image);

            string fileName = $"{Guid.NewGuid()}-{slider.Photo.FileName}";

            string newPath = _env.GetFilePath("img", fileName);

            Slider dbSlider = await _context.Sliders.FirstOrDefaultAsync(m => m.Id == slider.Id);

            dbSlider.Image = fileName;

            await _context.SaveChangesAsync();

            if (File.Exists(oldPath))
            {
                File.Delete(oldPath);
            }

            await slider.Photo.SaveFileAsync(newPath);
        }

        public async Task<List<SliderVM>> GetAllAsync()
        {
            return await _context.Sliders.Select(m => new SliderVM { Id = m.Id, Image = m.Image, /*Status = m.Status*/ })
                                         .ToListAsync();

        }

        public Task<List<SliderVM>> GetAllWithTrueStatusAsync()
        {
            throw new NotImplementedException();
        }

        //public async Task<List<SliderVM>> GetAllWithTrueStatusAsync()
        //{
        //    return await _context.Sliders.Where(m => m.Status)
        //                                 .Select(m => new SliderVM { Id = m.Id, Image = m.Img, /*Status = m.Statu*/s })
        //                                 .ToListAsync();
        //}

        public async Task<SliderVM> GetByIdAsync(int id)
        {

            return await _context.Sliders.Where(m => m.Id == id)
                                         .Select(m => new SliderVM { Id = m.Id, Image = m.Image/* Status = m.Status*/ })
                                         .FirstOrDefaultAsync();
        }

    
    }
}
