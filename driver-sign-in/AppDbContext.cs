using Microsoft.AspNetCore.Components.Routing;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Security.Principal;
using driver_sign_in.Models.Dtos;
using driver_sign_in.Models.Entities;

namespace driver_sign_in
{
    //Use next command in Package Manager Console to update Dev env DB
    //PM> $env:ASPNETCORE_ENVIRONMENT = 'Debug'; Update-Database
    public class AppDbContext : DbContext
    {
        public DbSet<InvoiceEntity> Invoices { get; set; }
        public DbSet<ProductEntity> Products { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}
