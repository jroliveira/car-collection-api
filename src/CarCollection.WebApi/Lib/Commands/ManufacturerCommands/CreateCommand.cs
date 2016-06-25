using System.Collections.Generic;
using CarCollection.WebApi.Models;

namespace CarCollection.WebApi.Lib.Commands.ManufacturerCommands
{
    public class CreateCommand : ICommand<Manufacturer>
    {
        private readonly ICollection<Manufacturer> _collection;

        protected CreateCommand()
        {

        }

        public CreateCommand(ICollection<Manufacturer> collection)
        {
            _collection = collection;
        }

        public virtual void Execute(Manufacturer item)
        {
            _collection.Add(item);
        }
    }
}
