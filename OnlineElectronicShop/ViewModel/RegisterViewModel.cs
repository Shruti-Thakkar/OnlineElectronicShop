using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;

namespace OnlineElectronicShop.ViewModel
{
    public class RegisterViewModel
    {
        
        public string? id { get; set; }
        
        public string? Email { get; set; }
        public string? Password { get; set; }

        [Compare ("Password")]
        public string? ConfirmedPassword { get; set; }


    }
}
