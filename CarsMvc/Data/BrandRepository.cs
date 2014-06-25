using CarsMvc.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CarsMvc.Data
{
    public class BrandRepository : Repository<BrandCar>, IBrandRepository
    {
        public BrandRepository(DbContext context,bool sharedContext) : base(context,sharedContext)
        {}


        public BrandCar GetBy(int id)
        {
            return DbSet.SingleOrDefault(b => b.ID == id);
        }
    }
}