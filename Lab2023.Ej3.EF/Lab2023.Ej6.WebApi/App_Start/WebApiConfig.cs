using System.Web.Http;
using System.Web.Http.Cors;

namespace Lab2023.Ej6.WebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Configuración y servicios de Web API

            // Rutas de Web API
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            // Habilitando CORS
            var cors = new EnableCorsAttribute("http://localhost:4500", "*", "*");
            config.EnableCors(cors);
        }
    }
}
