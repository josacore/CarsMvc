using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarsMvc.ViewModel
{
    public class TypeCreateViewModel
    {
        [Required(ErrorMessage="Please enter a name of Type.")]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}