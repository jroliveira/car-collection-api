using System.Linq;
using CarCollection.WebApi.Lib.Collections;

namespace CarCollection.WebApi.Lib.Commands.VehicleCommands
{
    public class DeleteCommand : ICommand<int>
    {
        private readonly VehicleCollection _collection;

        protected DeleteCommand()
        {

        }

        public DeleteCommand(VehicleCollection collection)
        {
            _collection = collection;
        }

        public virtual void Execute(int id)
        {
            var item = _collection.FirstOrDefault(current => current.Id == id);

            _collection.Remove(item);
        }
    }
}
