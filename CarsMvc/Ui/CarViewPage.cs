using CarsMvc.Data;
using CarsMvc.Models;
using CarsMvc.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarsMvc.Ui
{
    public abstract class CarViewPage : WebViewPage
    {
        protected IContext DataContext;
        public User CurrentUser { get; set; }
        public ICarService Cars { get; set; }
        public IImageCarService ImageCars { get; set; }
        public IUserService Users { get; set; }
        public IModelService Models { get; set; }
        public IBrandService Brands { get; set; }
        public ITypeService Types { get; set; }
        public ISecurityService Security { get; set; }
        
        public CarViewPage()
        {
            DataContext = new Context();
            Users = new UserService(DataContext);
            Cars = new CarService(DataContext);
            ImageCars = new ImageCarService(DataContext);
            Models = new ModelService(DataContext);
            Brands = new BrandService(DataContext);
            Types = new TypeService(DataContext);
            Security = new SecurityService(Users);
            CurrentUser = Security.GetCurrentUser();

        }
    }
    public abstract class CarViewPage<TModel> : WebViewPage<TModel>
    {
        protected IContext DataContext;
        public User CurrentUser { get; set; }
        public ICarService Cars { get; set; }
        public IImageCarService ImageCars { get; set; }
        public IUserService Users { get; set; }
        public IModelService Models { get; set; }
        public IBrandService Brands { get; set; }
        public ITypeService Types { get; set; }
        public ISecurityService Security { get; set; }

        public CarViewPage()
        {
            DataContext = new Context();
            Users = new UserService(DataContext);
            Cars = new CarService(DataContext);
            ImageCars = new ImageCarService(DataContext);
            Models = new ModelService(DataContext);
            Brands = new BrandService(DataContext);
            Types = new TypeService(DataContext);
            Security = new SecurityService(Users);
            CurrentUser = Security.GetCurrentUser();

        }
    }
}