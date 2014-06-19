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
            if (Security.IsAuthenticate)
            {
                return RedirectToAction("Index", new { controller = "Home", action = "index" });
            }
            
            model.Signup = new SignupViewModel();
            var login = model.Login;
            if (!ModelState.IsValid) {
                return View("Landing",model);
            }
            Security.Login(model.Login.Username);
            return RedirectToAction("Index", "home");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Logout() {
            if(Security.IsAuthenticate){
                Security.Logout();
            }
            return RedirectToAction("index", "Home");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Signup(LoginSignupViewModel model) 
        {
            if(Security.IsAuthenticate) {
                return RedirectToAction("Index", new { controller="Home", action="index"});
            }
            model.Login = new LoginViewModel();
            var signup = model.Signup;

            if(!ModelState.IsValid) {
                return View("Landing",model);
            }
            if(Security.DoesUserExits(model.Signup.Username)) {
                ModelState.AddModelError("Username", "The username already exists please chosse another.");
                return View("Landing",model);
            }
            Security.CreateUser(model.Signup);
            return RedirectToAction("Index", "Home");
        }
    }
}
