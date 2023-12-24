using EnergyBackendWebsite.ViewModels;

namespace EnergyBackendWebsite.Services.Interfaces
{
    public interface ISliderService
    {
        Task<List<SliderVM>> GetAllAsync();
        Task<List<SliderVM>> GetAllWithTrueStatusAsync();
        Task<SliderVM> GetByIdAsync(int id);
        Task DeleteAsync(int id);
        Task EditAsync(SliderEditVM slider);
    }
}
