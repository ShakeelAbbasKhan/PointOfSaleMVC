using System.ComponentModel.DataAnnotations;

namespace PointOfSaleMVC.ViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
