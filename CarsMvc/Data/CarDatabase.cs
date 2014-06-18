using CarsMvc.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace CarsMvc.Data
{
    public class CarDatabase : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<UserProfile> Profiles { get; set; }

        public CarDatabase() : base("CarConnection") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}