using EnergyBackendWebsite.Models;

namespace EnergyBackendWebsite.ViewModels
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public About About { get; set; }
        public string UserFullName { get; set; }
    }
}
