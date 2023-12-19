﻿using EnergyBackendWebsite.Models;
using Microsoft.EntityFrameworkCore;

namespace EnergyBackendWebsite.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
    }
}
