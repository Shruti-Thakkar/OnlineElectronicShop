using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;

namespace OnlineElectronicShop.ViewModel
{
    public class LoginViewModel
    {
        
        public string? UserName{ get; set; }
   
        public string? Password { get; set; }
    }
}
