using System.Collections.Generic;
using System.Linq;
using CarCollection.WebApi.Models;

namespace CarCollection.WebApi.Lib.Commands.ManufacturerCommands
{
    public class DeleteCommand : ICommand<int>
    {
        private readonly ICollection<Manufacturer> _collection;

        protected DeleteCommand()
        {

        }

        public DeleteCommand(ICollection<Manufacturer> collection)
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
