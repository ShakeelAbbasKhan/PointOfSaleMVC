using Microsoft.AspNetCore.Mvc;
using PointOfSaleMVC.ImageModels;

namespace PointOfSaleMVC.Controllers
{
    public class ImageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult FileUpload()
        {
            return View();
        }
        [HttpPost]
        public IActionResult FileUpload([FromForm] FileUpload model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Success");
            }
            return View(model); // Return to the view with validation error messages.
        }

        [HttpGet]
        public IActionResult Success() 
        {
            return View();
        }
    }
}
