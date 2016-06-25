using System;
using System.Collections.Generic;
using System.Web.Http;
using CarCollection.WebApi.Models;

namespace CarCollection.WebApi.Controllers
{
    public class VehicleTypesController : ApiController
    {
        [HttpGet]
        public IEnumerable<string> All()
        {
            var model = Enum.GetNames(typeof(VehicleType)); 

            return model;
        }
    }
}
