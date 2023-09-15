using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SalesCRMApp.Models;

namespace SalesCRMApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    // DbSet for your custom application entity
    public DbSet<SalesLeadEntity> SalesLead { get; set; }
    public DbSet<ApplicationUser> ApplicationUser { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder); // Include the base Identity configuration

        // Configure your custom application entity
        modelBuilder.Entity<SalesLeadEntity>().HasData(
            new SalesLeadEntity { Id = 1, FirstName = "John", LastName = "Dias", Mobile = "738333333", Email = "john@yahoo.com", Source = "Website" },
            new SalesLeadEntity { Id = 2, FirstName = "Regina", LastName = "Rodrigues", Mobile = "939393939", Email = "regina@gmail.com", Source = "Youtube" }
        );

    }
}
}
