using Microsoft.AspNetCore.Mvc;
using Kit19.Model;
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
            var results = _context.Product
                .Where(p =>
                    (string.IsNullOrEmpty(searchViewModel.ProductName) || p.ProductName == searchViewModel.ProductName) &&
                    (!searchViewModel.Size.HasValue || p.Size.Equals(searchViewModel.Size)) &&
                    (!searchViewModel.Price.HasValue || p.Price == searchViewModel.Price) &&
                    (!searchViewModel.MfgDate.HasValue || p.MfgDate == searchViewModel.MfgDate) &&
                    (string.IsNullOrEmpty(searchViewModel.Category) || p.Category == searchViewModel.Category)
                )
                .ToList();

            return View("SearchResult", results);
        }
    }
}
