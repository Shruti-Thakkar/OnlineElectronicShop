using MailKit.Net.Smtp;
using MimeKit;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol;
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
        public IActionResult Product(int pg=1)
        {
            var products = _context.Products.ToList();
            const int pageSize = 3;
            if(pg < 1)
            {
                pg = 1;
            }
            int recsCount = products.Count();
            var pager = new Pager(recsCount,pg, pageSize);
            int recSkip = (pg - 1) * pageSize;
             var data = products.Skip(recSkip).Take(pager.PageSize).ToList();
            this.ViewBag.Pager=pager;
            return View(data);
        }
        public IActionResult ProductCategory ( int id)
        {
            var product = _context.Products
                .Where(c=> c.CatId==id)
                .ToList();

            return View(product);
        }
        [HttpPost]
        public IActionResult Search(string productName)
        {
            var products = _context.Products
                .Where(p=> p.ProductName==productName)
                .ToList();
            return View(products);
        }
        public IActionResult ProductDetails(int? id)
        {
            var product = _context.Products.Include(c =>c.Category).FirstOrDefault(p=>p.ProductId==id);
            
            return View(product);
        }
        public IActionResult WishDetails(int? id)
        {
            var product = _context.Products.Include(c => c.Category).FirstOrDefault(p => p.ProductId == id);

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
        [HttpPost]
        public IActionResult Contact(Contact model)
        {
            if (ModelState.IsValid)
            {
               using (var client  = new SmtpClient())
                {
                    client.Connect("smtp.gmail.com");
                    client.Authenticate("srt1625@gmail.com", "pweyenqqxljeuevx");
                    var bodyBuilder = new BodyBuilder()
                    {
                        HtmlBody = $"<p>{model.ConName}</p> <p>{model.ConEmail}</p> <p>{model.ConPhone}</p> <p>{model.ConMessege}</p>",
                        TextBody = "{model.ConName} \r\n {model.ConEmail} \r\n {model.ConPhone} \r\n {model.ConMessege}"
                    };
                    var message = new MimeMessage
                    {
                        Body = bodyBuilder.ToMessageBody(),
                    };
                    message.From.Add(new MailboxAddress("Do Not Reply", model.ConEmail));
                    message.To.Add(new MailboxAddress("Testing","srt1625@gmail.com"));
                    message.Subject = model.ConMessege;
                    client.Send(message); 
                    client.Disconnect(true);

                }
                TempData["Message"] = "Thank you for your Inquiry, We will contact you shortly";
                return RedirectToAction(nameof(Contact));

            }

            
            return View(model);
        }
          [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}