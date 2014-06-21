using CarsMvc.Models;
using CarsMvc.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarsMvc.Controllers
{
    public class BrandController : CarControllerBase
    {
        //
        // GET: /Brand/

        public ActionResult Index()
        {
            var brands = Brands.All();
            return View(brands);
        }
        public ActionResult Create() 
        {
            if (!Security.IsAuthenticate)
            {
                return RedirectToAction("index","brand");
            }
            return View("Create", new BrandCreateViewModel());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(BrandCreateViewModel model)
        {
            if (!Security.IsAuthenticate) 
            {
                return RedirectToAction("index", "brand");
            }
            if (Brands.DoesBrandExists(model.Name)) {
                ModelState.AddModelError("Name", "This brand already existe please change.");
            }
            if (!ModelState.IsValid)
            {
                return View("Create",model);
            }
            Brands.Create(model);
            return RedirectToAction("index", "brand");
        }
    }
}
