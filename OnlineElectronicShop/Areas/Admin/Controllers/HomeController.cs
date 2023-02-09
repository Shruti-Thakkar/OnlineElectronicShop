using Microsoft.AspNetCore.Mvc;
using OnlineElectronicShop.Data;

namespace OnlineElectronicShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    
    public class HomeController : Controller
    {
        private readonly OnlineElectronicShopContext _context;

        public HomeController(OnlineElectronicShopContext context)
        {
                _context = context; 
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ShowingMessage()
        {
            var message = _context.Contacts.ToList();
            return View(message);
        }
    }
}
