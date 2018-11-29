﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CanjeLibros
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Login", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Registro",
                url: "{controller}/{action}",
                defaults: new { controller = "Registro", action = "Index" }
            );

            routes.MapRoute(
                name: "Login",
                url: "{controller}/{action}",
                defaults: new { controller = "Login", action = "Index" }
            );

            routes.MapRoute(
                name: "UserCreated",
                url: "{controller}/{action}",
                defaults: new { controller = "Login", action = "UserCreated", registroExitoso = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Libros",
                url: "{controller}/{action}",
                defaults: new { controller = "Libroes", action = "Index" }
            );
        }
    }
}
