using CarsMvc.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarsMvc.Controllers
{
    public class CarController : CarControllerBase
    {
        //
        // GET: /Car/

        public ActionResult Index()
        {
            var cars = Cars.All();
            return View("CarList",cars);
        }
        public ActionResult Create()
        {
            if (!Security.IsAuthenticate) {
                return RedirectToAction("Index", "Car");
            }
            return View("Create",new CarCreateViewModel());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CarCreateViewModel model)
        {
            if (!Security.IsAuthenticate)
            {
                return RedirectToAction("Index", "Car");
            }
            if(!ModelState.IsValid)
            {
                return View("Create",model);
            }
            return RedirectToAction("Index", "Car");
        }
    }
}
