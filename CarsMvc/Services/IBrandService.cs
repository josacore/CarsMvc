using CarsMvc.Models;
using CarsMvc.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace CarsMvc.Services
{
    public interface IBrandService
    {
        IEnumerable<BrandCar> All();
        BrandCar Create(BrandCreateViewModel model);
        bool DoesBrandExists(string Name);
    }
}