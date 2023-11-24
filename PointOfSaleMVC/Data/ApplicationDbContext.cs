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
    }
}
