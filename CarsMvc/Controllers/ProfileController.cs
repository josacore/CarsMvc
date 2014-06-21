using CarsMvc.ViewModel;
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
            Models.UserProfile profile = Profiles.GetBy(Security.GetCurrentUser().UserProfileId);
            return View(new EditProfileViewModel() { 
                ID = profile.ID,
                Email = profile.Email,
                Name = profile.Name,
                Bio = profile.Bio
            });
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EditProfileViewModel model) {
            if (!Security.IsAuthenticate) {
                return RedirectToAction("index", "Home");
            }
            if (!ModelState.IsValid) {
                return View("Edit",model);
            }
            Profiles.Update(model);
            return RedirectToAction("Index", "Profile");
        }
    }
}
