using System;
using System.Net.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Dispatcher;
using CarCollection.WebApi.Lib.IoC;

namespace CarCollection.WebApi.App_Start
{
    public class StructureMapHttpControllerActivator : IHttpControllerActivator
    {
        public IHttpController Create(HttpRequestMessage request, HttpControllerDescriptor controllerDescriptor, Type controllerType)
        {
            if (controllerType == null)
            {
                return null;
            }

            return Container.Get(controllerType) as IHttpController;
        }
    }
}