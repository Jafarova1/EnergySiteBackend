using Microsoft.AspNetCore.Identity;

namespace EnergyBackendWebsite.Models
{
    public class AppUser:IdentityUser
    {
        public string FullName { get; set; }

    }
}
