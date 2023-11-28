using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using PointOfSaleMVC.ImageModels;

namespace PointOfSaleMVC.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public int Size { get; set; }
        [Required]
        public DateTime ManufactoringDate { get; set; }
        [Required]
        public DateTime ExpirationDate { get; set; }

        //navigation property: configure one-t0-many relationship with Photo   
        public List<Photo>? Photos { get; set; }

        [NotMapped]

        [MaxFileSize(2 * 1024 * 1024, ErrorMessage = "File size exceeds the limit.")]
        [MaxFileCount(5, ErrorMessage = "You can upload up to 5 files.")]
        [AllowedFileExtensions(new[] { ".jpg", ".png", ".gif" }, ErrorMessage = "Only .jpg, .png, and .gif files are allowed.")]
        public List<IFormFile> Files { get; set; }
    }
}
