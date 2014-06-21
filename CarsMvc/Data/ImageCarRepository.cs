using CarsMvc.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CarsMvc.Data
{
    public class ImageCarRepository : Repository<ImageCar> , IImageCarRepository
    {
        public ImageCarRepository(DbContext context,bool sharedContext) : base(context,sharedContext)
        {}
    }
}