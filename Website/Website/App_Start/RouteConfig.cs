using System.Web.Mvc;
using System.Web.Routing;

namespace Website
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "show", id = UrlParameter.Optional }
            );

            /*routes.MapRoute(
                name: "catalog",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Catalog", action = "index", id = UrlParameter.Optional }
            );*/
        }
    }
}
