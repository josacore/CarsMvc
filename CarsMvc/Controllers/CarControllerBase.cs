using CarsMvc.Data;
using CarsMvc.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarsMvc.Controllers
{
    public class CarControllerBase : Controller
    {
        protected IContext DataContext;
        public IUserService Users { get; private set; }
        public IUserProfileService Profiles { get; private set; }
        public ISecurityService Security { get; private set; }

        public CarControllerBase()
        {
            DataContext = new Context();
            Users = new UserService(DataContext);
            Profiles = new UserProfileService(DataContext);
            Security = new SecurityService(Users);
        }
        protected override void Dispose(bool disposing)
        {
            if (DataContext != null)
            {
                DataContext.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}