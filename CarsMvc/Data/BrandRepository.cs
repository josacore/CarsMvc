using CarsMvc.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CarsMvc.Data
{
    public class BrandRepository : Repository<Brand>, IBrandRepository
    {
        public BrandRepository(DbContext context,bool sharedContext) : base(context,sharedContext)
        {}
    }
}