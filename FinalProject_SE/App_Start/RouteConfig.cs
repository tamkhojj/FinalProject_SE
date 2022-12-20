using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace FinalProject_SE
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
              name: "Contact",
              url: "Contact",
              defaults: new { controller = "Contact", action = "Index", alias = UrlParameter.Optional },
              namespaces: new[] { "FinalProject_SE.Controllers" }
          );
            routes.MapRoute(
         name: "CheckOut",
         url: "Checkout",
         defaults: new { controller = "ShoppingCart", action = "CheckOut", alias = UrlParameter.Optional },
         namespaces: new[] { "FinalProject_SE.Controllers" }
     );
            routes.MapRoute(
             name: "ShoppingCart",
             url: "ShoppingCart ",
             defaults: new { controller = "ShoppingCart", action = "Index", alias = UrlParameter.Optional },
             namespaces: new[] { "FinalProject_SE.Controllers" }
         );
            routes.MapRoute(
              name: "CategoryProduct",
              url: "ProductCategory/{alias}-{id}",
              defaults: new { controller = "Products", action = "ProductCategory", id = UrlParameter.Optional },
              namespaces: new[] { "FinalProject_SE.Controllers" }
          );
            routes.MapRoute(
              name: "detailProduct",
              url: "Detail/{alias}-p{id}",
              defaults: new { controller = "Products", action = "Detail", alias = UrlParameter.Optional },
              namespaces: new[] { "FinalProject_SE.Controllers" }
          );
            routes.MapRoute(
               name: "Products",
               url: "Product",
               defaults: new { controller = "Products", action = "Index", alias = UrlParameter.Optional },
               namespaces: new[] { "FinalProject_SE.Controllers" }
           );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "FinalProject_SE.Controllers" }
            );
        }
    }
}
