using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Vidly
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes(); // set up Attribute Routing --> routing handled in the Controller

            //// custom route: typically don't do it here! ... use attributes (Attribute Routing)
            //routes.MapRoute(
            //    "MoviesByReleaseDate",
            //    "movies/released/{year}/{month}",
            //    new { controller = "Movies", action = "ByReleaseDate" },
            //    new { year = @"\d{4}", month = @"\d{2}" } // year with 4 chars, month with 2 chars (e.g.: 4  -->  04)
            //    // new { year = @"2014|2015|2016|2017", month = @"\d{2}" }); // select from specified 4 given years, all others will be rejected
            //);

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
