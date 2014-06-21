using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CarsMvc.ViewModel
{
    public class BrandCreateViewModel
    {
        [Required(ErrorMessage="Please enter a Name.")]
        public string Name { get; set; }
        [MaxLength(200,ErrorMessage="The Description only can has less than 200 characters.")]
        public string Description { get; set; }
        public string UrlImage { get; set; }
        [NotMapped]
        public HttpPostedFileWrapper ImageUploaded { get; set; }
    }
}