using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PointOfSaleMVC.Models;

namespace PointOfSaleMVC.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }
        public DbSet<Photo> Photos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Photo>()
                .HasOne(p => p.Product)
                .WithMany(p => p.Photos)
                .HasForeignKey(p => p.ProductId);


            // Seed Categories
            for (int i = 1; i <= 60; i++)
            {
                modelBuilder.Entity<Category>().HasData(
                    new Category
                    {
                        Id = i,
                        Name = $"Category {i}",
                        Price = i * 10 // Adjust the pricing logic as needed
                    }
                );
            }

            base.OnModelCreating(modelBuilder);
        }
    }
}
