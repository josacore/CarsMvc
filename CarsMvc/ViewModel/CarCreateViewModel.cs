using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarsMvc.ViewModel
{
    public class CarCreateViewModel
    {
        [Display(Name = "Has A.C.")]
        public bool HasAirConditioning { get; set; }
        public string Comment { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        [Display(Name = "Publish Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DatePublish { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        public int BrandId { get; set; }
        [Required]
        public int ModelId { get; set; }
        [Required]
        public int TypeId { get; set; }
    }
}