using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarsMvc.ViewModel
{
    public class LoginViewModel
    {
        [Required(ErrorMessage="Please enter a Username.")]
        public string Username { get; set; }
        [Required(ErrorMessage="Please enter a Password.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}