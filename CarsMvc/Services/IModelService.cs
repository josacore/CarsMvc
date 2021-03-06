﻿using CarsMvc.Models;
using CarsMvc.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarsMvc.Services
{
    public interface IModelService
    {
        IEnumerable<ModelCar> All();
        ModelCar Create(ModelCreateViewModel model);
        bool DoesModelExists(string name);
    }
}