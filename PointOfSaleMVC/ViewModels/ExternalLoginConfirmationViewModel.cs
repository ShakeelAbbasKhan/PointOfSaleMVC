using System.ComponentModel.DataAnnotations;

namespace PointOfSaleMVC.ViewModels
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public string Name { get; set; }
    }
}
