using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using W24ExamFinal.Models;
using W24ExamFinal.ViewModels;

namespace W24ExamFinal.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly NorthwindContext _context;

        public HomeController(ILogger<HomeController> logger, NorthwindContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var supCategory = _context.Suppliers.Select(
                s => new HomeSup
                {
                    SupplierId = s.SupplierId,
                    SupplierName = s.CompanyName,
                    Top3 = s.Products.OrderBy(p => p.ProductName)
                    .Take(3)
                    .ToList()
                });
         
            return View(supCategory);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}