using CarCollection.WebApi.Lib.Collections;
using CarCollection.WebApi.Models;

namespace CarCollection.WebApi.Lib.Commands.VehicleCommands
{
    public class CreateCommand : ICommand<Vehicle>
    {
        private readonly VehicleCollection _collection;

        protected CreateCommand()
        {

        }

        public CreateCommand(VehicleCollection collection)
        {
            _collection = collection;
        }

        public virtual void Execute(Vehicle item)
        {
            _collection.Add(item);
        }
    }
}
