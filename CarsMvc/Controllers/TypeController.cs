using CarsMvc.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarsMvc.Controllers
{
    public class TypeController : CarControllerBase
    {
        
        public ActionResult Index()
        {
            var types = Types.All();
            return View(types);
        }
        public ActionResult Create() 
        {
            if (!Security.IsAuthenticate) 
            {
                return RedirectToAction("index", "Type");
            }
            return View("Create",new TypeCreateViewModel());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TypeCreateViewModel model)
        {
            if (!Security.IsAuthenticate) 
            {
                return RedirectToAction("index","type");
            }
            if (!ModelState.IsValid) {
                return View("create",model);
            }
            Types.Create(model);
            return RedirectToAction("index", "type");
        }
    }
}
