using System.Web.Mvc;
using System.Web.Routing;

namespace Lab2023.Ej6.MVC
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
                name: "Form",
                url: "Customer/Form/{idCustomer}",
                defaults: new { controller = "Customer", action = "Form", id = UrlParameter.Optional }
            );
        }
    }
}
