using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarsMvc.Models
{
    public class UserProfile
    {
        public int ID { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Bio { get; set; }
    }
}