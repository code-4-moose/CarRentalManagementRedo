using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CarRentalManagement.Domains;
using CarRentalManagement.Configuration.Entities;

namespace CarRentalManagement.Data
{
    public class CarRentalManagementContext : DbContext
    {
        public CarRentalManagementContext (DbContextOptions<CarRentalManagementContext> options)
            : base(options)
        {
        }

        public DbSet<CarRentalManagement.Domains.Make> Make { get; set; } = default!;
        public DbSet<CarRentalManagement.Domains.Model> Model { get; set; } = default!;
        public DbSet<CarRentalManagement.Domains.Colour> Colour { get; set; } = default!;
        public DbSet<CarRentalManagement.Domains.Vehicle> Vehicle { get; set; } = default!;
        public DbSet<CarRentalManagement.Domains.Booking> Booking { get; set; } = default!;
        public DbSet<CarRentalManagement.Domains.Customer> Customer { get; set; } = default!;

        protected override void OnModelCreating (ModelBuilder builder)
        {
            base.OnModelCreating (builder);

            //builder.ApplyConfiguration(new ColourSeed());
            builder.ApplyConfiguration(new MakeSeed());
            builder.ApplyConfiguration(new ModelSeed());
        }
    }
}
