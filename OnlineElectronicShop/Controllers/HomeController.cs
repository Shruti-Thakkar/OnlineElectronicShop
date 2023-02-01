using Microsoft.AspNetCore.Mvc;
using OnlineElectronicShop.Data;
using OnlineElectronicShop.Models;
using OnlineElectronicShop.ViewModel;
using System.Diagnostics;

namespace OnlineElectronicShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly OnlineElectronicShopContext _context;

        public HomeController(ILogger<HomeController> logger,OnlineElectronicShopContext context)
        {
            _logger = logger;
            _context = context; 
        }

        public IActionResult Index()
        {
            var model = new IndexViewModel
            {
                Categories = _context.Categories.ToList(),
                Products = _context.Products.ToList(),
            };
            return View(model);
        }
        public IActionResult Product()
        {
            var products = _context.Products.ToList();
            return View(products);
        }
        public IActionResult ProductCategory ( int id)
        {
            var product = _context.Products
                .Where(c=> c.CatId==id)
                .ToList();

            return View(product);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
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