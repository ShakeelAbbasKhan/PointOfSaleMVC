namespace PointOfSaleMVC.ImageModels
{
    public class FileUpload
    {
        
        [MaxFileSize(10 * 1024 * 1024, ErrorMessage = "File size exceeds the limit.")]
        [MaxFileCount(5, ErrorMessage = "You can upload up to 5 files.")]
        [AllowedFileExtensions(new[] { ".jpg", ".png", ".gif" }, ErrorMessage = "Only .jpg, .png, and .gif files are allowed.")]
        public List<IFormFile> Files { get; set; }
    }
}
