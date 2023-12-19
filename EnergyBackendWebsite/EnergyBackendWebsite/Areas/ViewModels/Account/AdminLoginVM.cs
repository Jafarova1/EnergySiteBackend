﻿using System.ComponentModel.DataAnnotations;

namespace EnergyBackendWebsite.Areas.ViewModels.Account
{
    public class AdminLoginVM
    {
        [Required]
        public string EmailOrUsername { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool IsRememberMe { get; set; }
    }
}