using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;

namespace OnlineElectronicShop.ViewModel
{
    public class LoginViewModel
    {
        [EmailAddress]
        public string? Email { get; set; }
   
        public string? Password { get; set; }
    }
}
