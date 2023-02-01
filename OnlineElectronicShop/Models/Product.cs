using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineElectronicShop.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public string? ProductName  { get; set; }
        public string? ProductDesc { get; set; }
        public string? ProductImg { get; set; }
        public decimal ProductPrice { get; set; }
        [NotMapped]
        public IFormFile? File { get; set; }
        public int CatId { get; set; }
        [ForeignKey("CatId")]
        public virtual Category Category { get; set; }

    }
}
