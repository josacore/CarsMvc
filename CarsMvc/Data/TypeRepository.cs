using CarsMvc.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CarsMvc.Data
{
    public class TypeRepository : Repository<TypeCar>,ITypeRepository
    {
        public TypeRepository(DbContext context,bool sharedContext) : base(context,sharedContext)
        {}
    }
}