using System.ComponentModel.DataAnnotations;

namespace EnergyBackendWebsite.ViewModels
{
    public class SliderCreateVM
    {
        [Required]
        public List<IFormFile> Photos { get; set; }
    }
}
