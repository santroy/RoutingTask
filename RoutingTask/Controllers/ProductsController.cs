using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RoutingTask.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public string Index(string genre)
        {
            return this.GetType().Name + ", " + System.Reflection.MethodBase.GetCurrentMethod().Name + ", param = " + genre;
        }
    }
}