﻿using CarsMvc.Models;
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
        public DbSet<ModelCar> Models { get; set; }
        public DbSet<BrandCar> Brands { get; set; }
        public DbSet<TypeCar> Types { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<ImageCar> ImageCars { get; set; }

        public CarDatabase() : base("CarConnection") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}