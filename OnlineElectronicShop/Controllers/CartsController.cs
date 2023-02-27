using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineElectronicShop.Data;
using OnlineElectronicShop.Models;
using Stripe;

namespace OnlineElectronicShop.Controllers
{
    public class CartsController : Controller
    {
        private readonly OnlineElectronicShopContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public CartsController(OnlineElectronicShopContext context,UserManager<ApplicationUser> userManager)
        {
           _context = context;
           _userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Cart()
        {
            var user = await _userManager.GetUserAsync(User);
            var result = _context.ShoppingCarts.Include(p=>p.Product).Where(u=>u.UserId== user.Id).ToList();

            return View(result);
        }
        [HttpPost]
        public async Task<IActionResult> AddToCart(ShoppingCart model,int qty)
        {
            var product = _context.Products.FirstOrDefault(p=>p.ProductId==model.ProductId);
            var user = await _userManager.GetUserAsync(User);
            var cart = new ShoppingCart
            {
                UserId = user.Id,
                ProductId = product.ProductId,
                Qty= qty,
            };
            var shopcart = _context.ShoppingCarts.FirstOrDefault(p=>p.UserId==user.Id && p.ProductId==model.ProductId);
            if(qty<=0)
            {
                qty= 1;
            }
            if(shopcart==null)
            {
                _context.ShoppingCarts.Add(cart);

            }
            else
            {
                shopcart.Qty=qty;
            }
            _context.SaveChanges();
            return RedirectToAction("Cart","Carts");
        }

        public async Task<IActionResult> Plus(int id)
        {
            var cart = _context.ShoppingCarts.FirstOrDefault(c => c.CartId==id);
            cart.Qty += 1;
            await _context.SaveChangesAsync();
            return RedirectToAction("cart");
        }
        public async Task<IActionResult> Minus(int id)
        {
            var cart = _context.ShoppingCarts.FirstOrDefault(c => c.CartId == id);
            if (cart.Qty == 1)
            {
                _context.ShoppingCarts.Remove(cart);
                _context.SaveChanges();
            }
            else
            {
                cart.Qty -= 1;
                await _context.SaveChangesAsync();

            }
            return RedirectToAction("cart");
        }
        [HttpPost]
        public async Task<IActionResult> RemoveCart(int id)
        {
            var user = await _userManager.GetUserAsync(User);
            var shopcart = _context.ShoppingCarts.FirstOrDefault(u => u.UserId==user.Id && u.CartId ==id);
            if (shopcart != null)
            {
                _context.ShoppingCarts.Remove(shopcart);

            }
            _context.SaveChanges();
            return RedirectToAction("Cart", "Carts");
        }
     
        public async Task<IActionResult> CartSummery()
        {
            var user = await _userManager.GetUserAsync(User);
            var result = _context.ShoppingCarts.Include(p => p.Product).Where(u => u.UserId == user.Id).ToList();

            return View(result);
        }
        [HttpPost]
        public async Task<IActionResult> ProceedToPay(String stripeToken,string stripeEmail)
        {
            var user = await _userManager.GetUserAsync(User);
            var result = _context.ShoppingCarts.Include(p => p.Product).Where(u => u.UserId == user.Id).ToList();
            ViewBag.result = result;
            ViewBag.DollarAmount = result.Sum(i =>i.Product.ProductPrice*i.Qty);
            ViewBag.total=Math.Round(ViewBag.DollarAmount,2)*100;
            ViewBag.total=Convert.ToInt64(ViewBag.Total);
            long total = ViewBag.Total;

            var customerOptions = new CustomerCreateOptions
            {
                Email = stripeEmail,
                Name = user.Name,
            };
            var customers = new CustomerService();
            Customer customer = customers.Create(customerOptions); var chargeOptions = new ChargeCreateOptions
            {
                Amount = Convert.ToInt64((ViewBag.DollarAmount) * 100),
                Currency = "Usd",
                Source = stripeToken,
                ReceiptEmail = stripeEmail,
                Metadata = new Dictionary<string, string>()
                {
                    {
                        "User id", 
                        user.Id 
                    },
                    {
                        "User Name", 
                        user.UserName 
                    }
                }
            }; 
            var service = new ChargeService();
            Charge charge = service.Create(chargeOptions);
            if (charge.Status == "succeeded")
            {
                string BalanceTransactionId = charge.BalanceTransactionId;
                //ViewBag.DollarAmount = Convert.ToDecimal(charge.Amount) % 100 / 100 + (charge.Amount) / 100;
                //ViewBag.BalanceTxId = BalanceTransactionId;
                return RedirectToAction(nameof(Successfull));
            }
            return View("Failure");
        }
        public async Task<IActionResult> Successfull()
        {
            var user = await _userManager.GetUserAsync(User);
            var result = _context.ShoppingCarts.Include(p => p.Product).Where(u => u.UserId == user.Id).ToList();

            return View(result);
        }
        public async Task<IActionResult> Wish()
        {
            var user = await _userManager.GetUserAsync(User);
            var result = _context.WishLists.Include(p => p.Product).Where(u => u.UserId == user.Id).ToList();

            return View(result);
        }
        [HttpPost]
        public async Task<IActionResult> AddToWishList(WishList model)
        {
            var product = _context.Products.FirstOrDefault(p => p.ProductId == model.ProductId);
            var user = await _userManager.GetUserAsync(User);
            var cart = new WishList
            {
                UserId = user.Id,
                ProductId = product.ProductId,
            };
            var shopcart = _context.WishLists.FirstOrDefault(p => p.UserId == user.Id && p.ProductId == model.ProductId);
            if (shopcart == null)
            {
                _context.WishLists.Add(cart);

            }
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
        [HttpPost]
        public async Task<IActionResult> RemoveWishList(int id)
        {
            var user = await _userManager.GetUserAsync(User);
            var shopcart = _context.WishLists.FirstOrDefault(u => u.UserId == user.Id && u.ProductId == id);
            if (shopcart != null)
            {
                _context.WishLists.Remove(shopcart);

            }
            _context.SaveChanges();
            return RedirectToAction("Wish", "Carts");
        }




    }
}

