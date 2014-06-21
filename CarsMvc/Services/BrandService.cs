using CarsMvc.Data;
using CarsMvc.Helpers;
using CarsMvc.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace CarsMvc.Services
{
    public class BrandService : IBrandService
    {
        private readonly IContext _context;
        private readonly IBrandRepository _brands;

        public BrandService(IContext context)
        {
            _context = context;
            _brands = context.Brands;
        }
        public IEnumerable<Models.Brand> All()
        {
            return _brands.All().ToArray();
        }
        public Models.Brand Create(ViewModel.BrandCreateViewModel model)
        {
            var saveImage = new SaveImage();
            string fileName = Guid.NewGuid().ToString();
            string urlImage = saveImage.ResizeAndSave(fileName, model.ImageUploaded.InputStream, Size.Small, false);

            var brand = new Brand() 
            { 
                Name = model.Name,
                Description = model.Description,
                UrlImage = urlImage
            };
            _brands.Create(brand);
            _context.SaveChanges();
            return brand;
        }
        public bool DoesBrandExists(string Name) 
        {
            return _brands.Find(b => b.Name == Name) != null ;
        }
    }
}