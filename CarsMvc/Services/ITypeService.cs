﻿using CarsMvc.Models;
using CarsMvc.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarsMvc.Services
{
    public interface ITypeService
    {
        IEnumerable<TypeCar> All();
        TypeCar Create(TypeCreateViewModel model);
    }
}