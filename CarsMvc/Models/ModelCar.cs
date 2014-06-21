using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CarsMvc.Models
{
    public class ModelCar
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        
        public int BrandId { get; set; }
        [ForeignKey("BrandId")]
        public virtual BrandCar Brand { get; set; }
    }
}