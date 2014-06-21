using CarsMvc.Data;
using CarsMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarsMvc.Services
{
    public class ModelService : IModelService
    {
        private readonly IContext _context;
        private readonly IModelRepository _models;

        public ModelService(IContext context)
        {
            _context = context;
            _models = context.Models;
        }
        public IEnumerable<Models.ModelCar> All()
        {
            return _models.All().ToArray();
        }


        public Models.ModelCar Create(ViewModel.ModelCreateViewModel model)
        {
            var itemModel = new ModelCar() 
            { 
                Name = model.Name,
                Description = model.Description,
                BrandId =model.BrandId
            };
            _models.Create(itemModel);
            _context.SaveChanges();
            return itemModel;
        }

        public bool DoesModelExists(string name)
        {
            return _models.Find(m => m.Name == name) != null ;
        }
    }
}