using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace RoutingTask.Controllers
{
    public class StaticController : Controller
    {
        // GET: Static
        public string Index()
        {
            //VirtualPathData path = RouteTable.Routes.GetVirtualPath(null, new RouteValueDictionary(new { controller = "Kontroler", action = "Akcja", id = "12", parametr = "Bartek" }));
            return this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name
                + "<br>";
        }

        public string About()
        {
            return this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name;
        }

    }
}