using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineElectronicShop.Models
{
    public class Category
    {
        [Key]
       public int CatId { get; set; }
        [Required]  
        public string? CatName { get; set; }
        public  string? CatImg { get; set; }
        [NotMapped]
        public IFormFile? File { get; set; } 
        public virtual ICollection<Product> Products{ get; set; }
    }
}

