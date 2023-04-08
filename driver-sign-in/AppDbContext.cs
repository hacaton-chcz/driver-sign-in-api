using Microsoft.AspNetCore.Components.Routing;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Security.Principal;
using driver_sign_in.Models.Dtos;

namespace driver_sign_in
{
    //Use next command in Package Manager Console to update Dev env DB
    //PM> $env:ASPNETCORE_ENVIRONMENT = 'Debug'; Update-Database
    public class AppDbContext : DbContext
    {
        public DbSet<InvoiceCreationDto> Invoices { get; set; }
        public DbSet<ProductCreationDto> Products { get; set; }
        public DbSet<CarCreationDto> Cars { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        //public AppDbContext()
        //{
        //    Database.EnsureCreated();
        //}
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseNpgsql("Host=localhost;Port=5433;Database=usersdb;Username=postgres;Password=postgres");
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}
