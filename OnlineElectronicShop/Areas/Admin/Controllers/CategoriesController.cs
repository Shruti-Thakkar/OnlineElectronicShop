using Microsoft.AspNetCore.Mvc;
using OnlineElectronicShop.Data;
using OnlineElectronicShop.Migrations;
using OnlineElectronicShop.Models;

namespace OnlineElectronicShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoriesController : Controller
    {
        private readonly OnlineElectronicShopContext _context;

        public CategoriesController( OnlineElectronicShopContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var categories = _context.Categories.ToList();
            return View(categories);
        }
        public IActionResult  Create() 
        { 
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Category model,IFormFile File )
        {
            if (File != null) 
            { 
                string imageName = Guid.NewGuid().ToString() + ".jpg";
                string filePathImage = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\CategoryImage" , imageName);
                using (var stream = System.IO.File.Create(filePathImage))
                {
                    await File.CopyToAsync(stream);
                   
                }
                model.CatImg = imageName;

            }
            _context.Add(model);
            await _context.SaveChangesAsync();  
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var category = _context.Categories.Find(id);
            return View(category);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Category model, IFormFile File)
        {
            if (File != null)
            {
                string imageName = Guid.NewGuid().ToString() + ".jpg";
                string filePathImage = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\CategoryImage", imageName);
                using (var stream = System.IO.File.Create(filePathImage))
                {
                    await File.CopyToAsync(stream);

                }
                model.CatImg = imageName;

            }
            _context.Update(model);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        
        public IActionResult Delete(int id)
        {
            if (id != null) 
            {
                var cat = _context.Categories.Find(id);
                _context.Categories.Remove(cat);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();   
            
        }
    }
}
