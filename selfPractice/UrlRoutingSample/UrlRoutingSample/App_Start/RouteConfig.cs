using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace UrlRoutingSample
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("ShopRoute", "Shop/{action}",
                new {controller = "Home", action ="Index"});

            routes.MapRoute("MyRoute", "{controller}/{action}/{id}/{name}",
                new {action = "Index", controller = "Home", id = "0", name = "Unknown"});
        }
    }
}
