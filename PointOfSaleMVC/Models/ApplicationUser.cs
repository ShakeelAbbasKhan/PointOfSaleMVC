using Microsoft.AspNetCore.Identity;

namespace PointOfSaleMVC.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
