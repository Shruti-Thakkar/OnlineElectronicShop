using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OnlineElectronicShop.Models
{
    public class Contact
    {
        [Key]
        public int ConId { get; set; }
        [Required]
        public string? ConName { get; set; }
        [Required]
        public string? ConEmail { get; set; }
        [Required]  
        public string? ConPhone { get; set; }
        [Required]
        public string? ConMessege { get; set; }
        
       
    }
}
