using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CarsMvc.Models
{
    public class Brand
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string UrlImage { get; set; }

        public virtual ICollection<Model> Models { get; set; }
    }
}