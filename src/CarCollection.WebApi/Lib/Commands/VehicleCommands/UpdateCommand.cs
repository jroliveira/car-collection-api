using System;
using System.Linq;
using CarCollection.WebApi.Lib.Collections;
using CarCollection.WebApi.Models;

namespace CarCollection.WebApi.Lib.Commands.VehicleCommands
{
    public class UpdateCommand : ICommand<Vehicle>
    {
        private readonly VehicleCollection _collection;

        protected UpdateCommand()
        {

        }

        public UpdateCommand(VehicleCollection collection)
        {
            _collection = collection;
        }

        public virtual void Execute(Vehicle item)
        {
            var actual = _collection.FirstOrDefault(current => current.Id == item.Id);
            if (actual == null)
            {
                throw new NullReferenceException($"Vehicle {item.Id} is null");
            }

            actual.Model = item.Model;
            actual.Note = item.Note;
            actual.Manufacturer = item.Manufacturer;
            actual.Type = item.Type;
        }
    }
}
