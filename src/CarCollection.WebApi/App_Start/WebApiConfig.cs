using System.Net.Http.Headers;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Routing;
using Newtonsoft.Json.Serialization;

namespace CarCollection.WebApi.App_Start
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            GlobalConfiguration.Configuration.Formatters.JsonFormatter.SerializerSettings.Converters.Add(new Newtonsoft.Json.Converters.StringEnumConverter());
            var enableCorsAttribute = new EnableCorsAttribute(
                "*",
                "Origin, Content-Type, Accept",
                "GET, PUT, POST, DELETE, OPTIONS");
            config.EnableCors(enableCorsAttribute);
            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));
            config.Formatters.JsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            config.Formatters.JsonFormatter.Indent = true;

            ManufacturersRegister(config.Routes);
            VehiclesRegister(config.Routes);
            VehicleTypesRegister(config.Routes);

            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                "Home",
                "",
                new { controller = "Home", action = "Info" },
                new { httpMethod = new HttpMethodConstraint("Get") }
            );

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }

        private static void ManufacturersRegister(HttpRouteCollection routes)
        {
            routes.MapHttpRoute(
                "AllManufacturers",
                "manufacturers",
                new { controller = "Manufacturers", action = "All" },
                new { httpMethod = new HttpMethodConstraint("Get") }
            );

            routes.MapHttpRoute(
                "GetByManufacturers",
                "manufacturers/{id}",
                new { controller = "Manufacturers", action = "GetBy" },
                new { httpMethod = new HttpMethodConstraint("Get") }
            );

            routes.MapHttpRoute(
                "PostManufacturers",
                "manufacturers",
                new { controller = "Manufacturers", action = "Create" },
                new { httpMethod = new HttpMethodConstraint("Post") }
            );

            routes.MapHttpRoute(
                "PutManufacturers",
                "manufacturers",
                new { controller = "Manufacturers", action = "Update" },
                new { httpMethod = new HttpMethodConstraint("Put") }
            );

            routes.MapHttpRoute(
                "DeleteManufacturers",
                "manufacturers/{id}",
                new { controller = "Manufacturers", action = "Delete" },
                new { httpMethod = new HttpMethodConstraint("Delete") }
            );
        }

        private static void VehiclesRegister(HttpRouteCollection routes)
        {
            routes.MapHttpRoute(
                "AllVehicles",
                "vehicles",
                new { controller = "Vehicles", action = "All" },
                new { httpMethod = new HttpMethodConstraint("Get") }
            );

            routes.MapHttpRoute(
                "GetByVehicles",
                "vehicles/{id}",
                new { controller = "Vehicles", action = "GetBy" },
                new { httpMethod = new HttpMethodConstraint("Get") }
            );

            routes.MapHttpRoute(
                "PostVehicles",
                "vehicles",
                new { controller = "Vehicles", action = "Create" },
                new { httpMethod = new HttpMethodConstraint("Post") }
            );

            routes.MapHttpRoute(
                "PutVehicles",
                "vehicles",
                new { controller = "Vehicles", action = "Update" },
                new { httpMethod = new HttpMethodConstraint("Put") }
            );

            routes.MapHttpRoute(
                "DeleteVehicles",
                "vehicles/{id}",
                new { controller = "Vehicles", action = "Delete" },
                new { httpMethod = new HttpMethodConstraint("Delete") }
            );
        }

        private static void VehicleTypesRegister(HttpRouteCollection routes)
        {
            routes.MapHttpRoute(
                "AllVehicleTypes",
                "vehicle-types",
                new { controller = "VehicleTypes", action = "All" },
                new { httpMethod = new HttpMethodConstraint("Get") }
            );
        }
    }
}
