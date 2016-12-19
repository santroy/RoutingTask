using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace RoutingTask
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Gatunki",
                url: "gatunki/{genre}",
                defaults: new { controller = "Products", action = "Index", genre = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "O nas",
                url: "onas",
                defaults: new { controller = "Static", action = "About"}
            );

            routes.MapRoute(
                name: "Static",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Static", action = "Index", id = UrlParameter.Optional }
            );




        }
    }
}
