using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Maharaja_Tandoori
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                  name: "getItems",
                  url: "{controller}/{action}/",
                  defaults: new { controller = "apis", action = "getItems" }
                );

            routes.MapRoute(
                 name: "getPostalCodes",
                 url: "{controller}/{action}",
                 defaults: new { controller = "apis", action = "getPostalCodes" }
               );

            routes.MapRoute(
                 name: "getInfo",
                 url: "{controller}/{action}",
                 defaults: new { controller = "apis", action = "getInfo" }
               );

            routes.MapRoute(
                 name: "verifyCoupon",
                 url: "{controller}/{action}/{coupon}",
                 defaults: new { controller = "apis", action = "verifyCoupon" }
               );
            routes.MapRoute(
                 name: "saveOrder",
                 url: "{controller}/{action}/{json}",
                 defaults: new { controller = "apis", action = "saveOrder" }
               );

            
        }
    }
}