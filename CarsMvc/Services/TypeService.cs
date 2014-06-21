using CarsMvc.Data;
using CarsMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarsMvc.Services
{
    public class TypeService : ITypeService
    {
        private readonly IContext _context;
        private readonly ITypeRepository _types;
        
        public TypeService(IContext context)
        {
            _context = context;
            _types = context.Types;
        }

        public IEnumerable<TypeCar> All() {
            return _types.All().ToArray();
        }


        public TypeCar Create(ViewModel.TypeCreateViewModel model)
        {
            var typecar = new TypeCar() 
            {
                Name = model.Name,
                Description = model.Description
            };
            _types.Create(typecar);
            _context.SaveChanges();
            return typecar;
        }
    }
}