using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SweetShop.Models
{
  public class SweetShopContext : IdentityDbContext<ApplicationUser>
  {
    public virtual DbSet<Treat> Treats { get; set; }
    public DbSet<Flavor> Flavors { get; set; }
    public DbSet<TreatFlavor> TreatFlavor { get; set; }
    public SweetShopContext(DbContextOptions options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);
      modelBuilder.Entity<Flavor>()
          .HasData(
              new Flavor { FlavorId = 1, FlavorName = "Sweet" },
              new Flavor { FlavorId = 2, FlavorName = "Salty" },
              new Flavor { FlavorId = 3, FlavorName = "Bitter" },
              new Flavor { FlavorId = 4, FlavorName = "Chocolatey" },
              new Flavor { FlavorId = 5, FlavorName = "Sour" },
              new Flavor { FlavorId = 6, FlavorName = "Fruity" },
              new Flavor { FlavorId = 7, FlavorName = "Umami" },
              new Flavor { FlavorId = 8, FlavorName = "Nutty" },
              new Flavor { FlavorId = 9, FlavorName = "Spicy" }
          );
    }
  }
}