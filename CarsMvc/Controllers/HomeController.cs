using CarsMvc.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarsMvc.Controllers
{
    public class HomeController : CarControllerBase
    {
        public HomeController():base(){}

        public ActionResult Index()
        {
            if (!Security.IsAuthenticate) {
                return View("Landing",new LoginSignupViewModel());
            }
            //vieww cars 
            return View("Landing");
        }

    }
}
