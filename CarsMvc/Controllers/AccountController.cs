using CarsMvc.ViewModel;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarsMvc.Controllers
{
    public class AccountController : CarControllerBase
    {
        //
        // GET: /Account/

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginSignupViewModel model)
        {
            model.Signup = new SignupViewModel();
            var login = model.Login;
            if (!ModelState.IsValid) {
                return View("Landing",model);
            }
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Signup(LoginSignupViewModel model) 
        {
            model.Login = new LoginViewModel();
            var signup = model.Signup;

            if (!ModelState.IsValid) {
                return View("Landing",model);
            }
            return View();
        }
    }
}
