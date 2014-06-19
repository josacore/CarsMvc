using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarsMvc.ViewModel
{
    public class SignupViewModel
    {
        [Required(ErrorMessage="Please enter a Username.")]
        public string Username { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage="Please enter a Password.")]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage="The password does not match.")]
        public string Password2 { get; set; }
        [Required(ErrorMessage="Please enter a Email.")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }
    }
}