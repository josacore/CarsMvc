using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CarsMvc.Models
{
    public class Car
    {
        public int ID { get; set; }
        public bool HasAirConditioning { get; set; }
        public string Comment { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        [DataType(DataType.Date)]
        public DateTime DatePublish { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        public int ModelId { get; set; }
        [ForeignKey("ModelId")]
        public virtual ModelCar ModelCar { get; set; }
        [Required]
        public int TypeCarId { get; set; }
        [ForeignKey("TypeCarId")]
        public virtual TypeCar TypeCar { get; set; }

        public virtual ICollection<ImageCar> Images { get; set; }
    }
}