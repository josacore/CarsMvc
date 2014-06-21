using CarsMvc.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarsMvc.Services
{
    public class ImageCarService : IImageCarService
    {
        private readonly IContext _context;
        private readonly IImageCarRepository _imageCars;
        
        public ImageCarService(IContext context)
        {
            _context = context;
            _imageCars = context.ImageCars;
        }
    }
}