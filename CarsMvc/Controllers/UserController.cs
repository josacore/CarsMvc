using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarsMvc.Controllers
{
    public class UserController : CarControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create() 
        {
            return View();
        }
    }
}
