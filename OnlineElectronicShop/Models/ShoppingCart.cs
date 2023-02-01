using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineElectronicShop.Models
{
    public class ShoppingCart
    {
        [Key]
        public int CartId { get; set; }
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
        [Range(1,int.MaxValue)]
        public int Qty { get; set; }

        public string UserId {get;set;}
        [ForeignKey("UserId")]
        public virtual   ApplicationUser ApplicationUser { get; set; }


    }
}
