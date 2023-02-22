using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;

namespace OnlineElectronicShop.ViewModel
{
    public class RegisterViewModel
    {
        
        public string? Id { get; set; }
        public  string? Name { get; set; }
        public string? UserName { get; set; }   
        public string? Email { get; set; }
        public string? Password { get; set; }

        [Compare ("Password")]
        public string? ConfirmedPassword { get; set; }
        public string? Role { get; set; }   


    }
}
