using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CarsMvc.Models
{
    public class ImageCar
    {
        public int ID { get; set; }
        
        public int CarId { get; set; }
        [ForeignKey("CarId")]
        public virtual Car Car { get; set; }

        public string UrlImageSmall { get; set; }
        public string UrlImageMiddle { get; set; }
    }
}