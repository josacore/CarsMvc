using CarsMvc.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CarsMvc.Data
{
    public class ModelRepository : Repository<Model>, IModelRepository
    {
        public ModelRepository(DbContext context, bool sharedContext)
            : base(context, sharedContext)
        { }
    }
}