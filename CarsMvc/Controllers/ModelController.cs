using CarsMvc.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarsMvc.Controllers
{
    public class ModelController : CarControllerBase
    {
        public ActionResult Index()
        {
            var models = Models.All();
            return View(models);
        }
        public ActionResult Create()
        {
            if(!Security.IsAuthenticate){
                return RedirectToAction("index","home");
            }

            int selectedStateId = 1;
            IEnumerable<SelectListItem> selectList =
                from b in Brands.All()
                select new SelectListItem
                {
                    Selected = (b.ID == selectedStateId),
                    Text = b.Name,
                    Value = b.ID.ToString()
                };
            return View("Create", new ModelCreateViewModel() { Brands = selectList });
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ModelCreateViewModel model) 
        {
            if (!Security.IsAuthenticate)
            {
                return RedirectToAction("index", "home");
            }
            if(Models.DoesModelExists(model.Name)){
                ModelState.AddModelError("Name","The Model already exist.");
            }
            if (!ModelState.IsValid) {
                int selectedStateId = model.BrandId;
                IEnumerable<SelectListItem> selectList =
                    from b in Brands.All()
                    select new SelectListItem
                    {
                        Selected = (b.ID == selectedStateId),
                        Text = b.Name,
                        Value = b.ID.ToString()
                    };
                model.Brands = selectList;
                return View("Create", model);
            }
            Models.Create(model);
            return RedirectToAction("index", "Model");
        }
    }
}
