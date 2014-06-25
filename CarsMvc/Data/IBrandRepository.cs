using CarsMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarsMvc.Data
{
    public interface IBrandRepository : IRepository<BrandCar>
    {
        BrandCar GetBy(int id);
    }
}