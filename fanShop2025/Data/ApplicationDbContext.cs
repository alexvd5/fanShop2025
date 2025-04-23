using fanShop2025.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace fanShop2025.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "BarcaFirstKit", Price = 115.00m, Description = "Barca's first kit season 2024/25" , Quantity = 100},
                new Product { Id = 2, Name = "BarcaAwayKit", Price = 100.00m, Description = "Barca's away kit season 2024/25",Quantity = 100},
                 new Product { Id = 3, Name = "BarcaGoalKeeperKit", Price = 115.00m, Description = "Barca's goalkeeper's kit season 2024/25", Quantity = 100 },
                  new Product { Id = 4, Name = "BarcaSecondAwayKit", Price = 100.00m, Description = "Barca's second away kit season 2024/25", Quantity = 100 }
                );
        }
    }
}
