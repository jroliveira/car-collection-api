using System;
using System.Collections.Generic;
using CarCollection.WebApi.Lib.Collections;
using CarCollection.WebApi.Models;
using StructureMap;

namespace CarCollection.WebApi.Lib.IoC
{
    public static class Container
    {
        private static readonly IContainer StructureMapContainer;

        static Container()
        {
            StructureMapContainer = ConfigureDependencies();
        }

        private static IContainer ConfigureDependencies()
        {
            return new StructureMap.Container(registry =>
            {
                registry.For<IQueryFactory>().Use<QueryFactory>();
                registry.For<ICommandFactory>().Use<CommandFactory>();
                registry.For<ICollection<Manufacturer>>().Use<ManufacturerCollection>();
                registry.For<ICollection<Vehicle>>().Use<VehicleCollection>();
            });
        }

        public static void Init() { }

        public static T Get<T>()
        {
            return StructureMapContainer.GetInstance<T>();
        }

        public static object Get(Type type)
        {
            return StructureMapContainer.GetInstance(type);
        }
    }
}
