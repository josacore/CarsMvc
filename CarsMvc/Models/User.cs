using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CarsMvc.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime DateCreated { get; set; }
        
        public int UserProfileId { get; set; }
        [ForeignKey("UserProfileId")]
        public UserProfile Profile { get; set; }
    }
}