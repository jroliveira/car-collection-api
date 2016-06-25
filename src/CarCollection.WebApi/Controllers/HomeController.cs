using System.Reflection;
using System.Web.Http;
using CarCollection.WebApi.Models;

namespace CarCollection.WebApi.Controllers
{
    public class HomeController : ApiController
    {
        [HttpGet]
        public Info Info()
        {
            var info = Assembly.GetExecutingAssembly().GetName();

            return new Info
            {
                Version = info.Version.ToString(),
                Message = "I'm working..."
            };
        }
    }
}
