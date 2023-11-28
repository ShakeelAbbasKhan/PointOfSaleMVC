using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PointOfSaleMVC.Data;
using PointOfSaleMVC.ImageModels;
using PointOfSaleMVC.Models;

namespace PointOfSaleMVC.Controllers
{
    public class ImageController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ImageController(ApplicationDbContext context)
        {
            _context = context;
        }
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

        [HttpGet]
        public IActionResult CreateProduct()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct([FromForm] Product product)
        {

            if (ModelState.IsValid)
            {
                //create a new Product instance.  
                Product newproduct = new()
                {
                    Description = product.Description,
                    Price = product.Price,
                    Size = product.Size,
                    ManufactoringDate = product.ManufactoringDate,
                    ExpirationDate = product.ExpirationDate
                };

                //create a Photo list to store the upload files.  
                List<Photo> photolist = new List<Photo>();
                if (product.Files.Count > 0)
                {
                    foreach (var formFile in product.Files)
                    {
                        if (formFile.Length > 0)
                        {
                            using (var memoryStream = new MemoryStream())
                            {
                                await formFile.CopyToAsync(memoryStream);
                                
                                    //You can also check the database, whether the image exists in the database.  
                                    var newphoto = new Photo()
                                    {
                                        Bytes = memoryStream.ToArray(),
                                        Description = formFile.FileName,
                                        FileExtension = Path.GetExtension(formFile.FileName),
                                        Size = formFile.Length,
                                       // ProductId = newproduct.Id
                                    };
                                    //add the photo instance to the list.  
                                    photolist.Add(newphoto);
                            }
                        }
                    }
                }
                //assign the photos to the Product, using the navigation property.  
                newproduct.Photos = photolist;

                _context.Products.Add(newproduct);
                _context.SaveChanges();

                return RedirectToAction("Success");
            }
            return View(product); // Return to the view with validation error messages.


        }
    }
}
