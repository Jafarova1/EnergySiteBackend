using Microsoft.AspNetCore.Identity;

namespace EnergyBackendWebsite.Models
{
    public class AppUser:IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public bool IsRememberMe { get; set; }

    }
}
