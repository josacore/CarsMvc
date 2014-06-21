using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CarsMvc
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            //Car
            routes.MapRoute(
                name: "Car",
                url: "Car/{action}",
                defaults: new { controller = "Car", action = "index" }
            );
            //Type
            routes.MapRoute(
                name: "Type",
                url: "Type/{action}",
                defaults: new { controller = "Type", action = "index" }
            );
            //Model
            routes.MapRoute(
                name: "Model",
                url: "Model/{action}",
                defaults: new { controller = "Model", action = "index" }
            );
            //Brand
            routes.MapRoute(
                name: "Brand",
                url: "Brand/{action}",
                defaults: new { controller = "Brand", action = "index" }
            );
            //Account
            routes.MapRoute(
                name: "Account",
                url: "Account/{action}",
                defaults: new { controller = "Account", action = "index" }
            );
            //profile
            routes.MapRoute(
                name: "Profile",
                url: "Profile/{action}",
                defaults: new { controller = "Profile", action = "index" }
            );
            //create
            routes.MapRoute(
                name: "userCreate",
                url: "userCreate",
                defaults: new { controller ="User", action="create"}
            );

            routes.MapRoute(
                name: "Default",
                url: "",
                defaults: new { controller = "Home", action = "index" }
            );
            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            //);
        }
    }
}