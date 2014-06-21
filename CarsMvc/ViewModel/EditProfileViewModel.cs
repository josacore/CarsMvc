using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarsMvc.ViewModel
{
    public class EditProfileViewModel
    {
        public int ID { get; set; }
        [Required(ErrorMessage="Please enter a Name.")]
        public string Name { get; set; }
        [Required(ErrorMessage="Please enter an Email.")]
        public string Email { get; set; }
        public string Bio { get; set; }
    }
}