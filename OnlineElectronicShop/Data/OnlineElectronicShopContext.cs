using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineElectronicShop.Models;

namespace OnlineElectronicShop.Data
{
    public class OnlineElectronicShopContext : IdentityDbContext<ApplicationUser>
    {
        public OnlineElectronicShopContext(DbContextOptions<OnlineElectronicShopContext> options)
            : base(options) { } 

        public DbSet<Category> Categories { get; set; } 

        public DbSet<Product> Products { get; set; }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<ShoppingCart> ShoppingCarts { get; set;}
    }
}
