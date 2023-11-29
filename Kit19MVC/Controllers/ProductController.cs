using Microsoft.AspNetCore.Mvc;
using Kit19.Models;
using Kit19.MyDbContext;

namespace Kit19.Controllers
{
    public class ProductController : Controller
    {
        private readonly Kit19DbContext _context;

        public ProductController(Kit19DbContext context)
        {
            _context = context;
        }

        public IActionResult Search()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Search(ProductViewModel searchViewModel)
        {
            var results = _context.SearchProducts(
                  searchViewModel.ProductName,
                  searchViewModel.Size,
                  searchViewModel.Price,
                  searchViewModel.MfgDate,
                  searchViewModel.Category
                );

            return View("SearchResult", results);
        }
    }
}
