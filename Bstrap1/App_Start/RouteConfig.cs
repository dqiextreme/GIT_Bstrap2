﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Bstrap2
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            //original
            //routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            //);

            routes.MapRoute(
                name: "Def", // any name meaningful for you is right
                url: "{controller}/{action}",
                defaults: new { controller = "Home", action = "Grid4" }
                //defaults: new { controller = "Account", action = "Login" }
            );
        }
    }
}