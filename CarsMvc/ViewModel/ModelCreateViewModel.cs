using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarsMvc.ViewModel
{
    public class ModelCreateViewModel
    {
        [Required(ErrorMessage="Please enter a Name.")]
        public string Name { get; set; }
        [MaxLength(200,ErrorMessage="The maximmun lenght for description is less than 200.")]
        public string Description { get; set; }
        public int BrandId { get; set; }

        public IEnumerable<SelectListItem> Brands { get; set; }
    }
}