using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCRoute
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            //Action üzerinde Route attribute'unu kullanıma açamk için

            routes.MapMvcAttributeRoutes();






            //Route Config açıldığında gelen route üzerine kendi route yazın, yani üstüne eklenmeli

            routes.MapRoute(
                name: "Product",
                url: "{ProductName}-p-{ProductID}",
                defaults: new
                {
                    controller = "Product",
                    action = "Details",
                    ProductName= UrlParameter.Optional,
                    ProductID = UrlParameter.Optional
                    
                });
                




            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
