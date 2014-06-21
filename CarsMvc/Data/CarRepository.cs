using CarsMvc.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CarsMvc.Data
{
    public class CarRepository : Repository<Car>, ICarRepository
    {
        public CarRepository(DbContext context,bool sharedContext) : base(context,sharedContext)
        {}
    }
}