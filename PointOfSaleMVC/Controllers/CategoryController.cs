using Microsoft.AspNetCore.Mvc;
using PointOfSaleMVC.Data;
using PointOfSaleMVC.Models;
using PointOfSaleMVC.PaginationModel;
using Microsoft.EntityFrameworkCore;

namespace PointOfSaleMVC.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CategoryController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index(string sortOrder, string searchString,string currentFilter, int? pageNumber)
        {
            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewData["CurrentFilter"] = searchString;
            var categories = from c in _context.Categories
                           select c;
            if (!String.IsNullOrEmpty(searchString))
            {
                categories = categories.Where(s => s.Name.Contains(searchString)
                                       || s.Price.ToString().Contains(searchString));
            }

            switch (sortOrder)
            {
                case "name":
                    categories = categories.OrderBy(s => s.Name);
                    break;
                case "price":
                    categories = categories.OrderBy(s => s.Price);
                    break;
                default:
                    categories = categories.OrderBy(s => s.Name);
                    break;
            }

            int pageSize = 10;
            return View(await PaginatedList<Category>.CreateAsync(categories.AsNoTracking(), pageNumber ?? 1, pageSize));

        }

        [HttpGet]
        public IActionResult GetCategory(int page = 1)
        {
            int pageSize = 10;
            IEnumerable<Category> result = _context.Categories;

            var orderByResult = result.OrderBy(x => x.Name).ThenBy(x => x.Price).ToList();

            var totalCount = orderByResult.Count();
            var totalPages = (int)Math.Ceiling((double)totalCount / pageSize);

            var paginatedCategories = orderByResult.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            ViewData["CurrentPage"] = page;
            ViewData["TotalPages"] = totalPages;

            return View(paginatedCategories);
        }


    }
}
