using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarsMvc.Controllers
{
    public class ProfileController : CarControllerBase
    {
        public ActionResult Index()
        {
            if (!Security.IsAuthenticate) 
            {
                return RedirectToAction("Index", "Home");
            }
            Models.User user = Security.GetCurrentUser();
            return View(user);
        }
        public ActionResult Edit() {
            if (!Security.IsAuthenticate)
            {
                return RedirectToAction("Index", "Home");
            }
            Models.User user = Security.GetCurrentUser();
            return View(user);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Models.User model) {
            if (!Security.IsAuthenticate) {
                return RedirectToAction("index", "Home");
            }
            if (!ModelState.IsValid) {
                return View("Edit",model);
            }
            return View();
        }
    }
}
