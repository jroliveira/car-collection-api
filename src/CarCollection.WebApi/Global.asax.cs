using System.Web.Http;
using System.Web.Http.Dispatcher;
using System.Web.Mvc;
using CarCollection.WebApi.App_Start;
using CarCollection.WebApi.Lib.IoC;

namespace CarCollection.WebApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            Container.Init();
            GlobalConfiguration.Configuration.Services.Replace(
                typeof(IHttpControllerActivator),
                new StructureMapHttpControllerActivator());
        }
    }
}
