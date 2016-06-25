using System;
using System.Collections.Generic;
using System.Linq;
using CarCollection.WebApi.Models;

namespace CarCollection.WebApi.Lib.Commands.ManufacturerCommands
{
    public class UpdateCommand : ICommand<Manufacturer>
    {
        private readonly ICollection<Manufacturer> _collection;

        protected UpdateCommand()
        {

        }

        public UpdateCommand(ICollection<Manufacturer> collection)
        {
            _collection = collection;
        }

        public virtual void Execute(Manufacturer item)
        {
            var actual = _collection.FirstOrDefault(current => current.Id == item.Id);
            if (actual == null)
            {
                throw new NullReferenceException($"Manufacturer {item.Id} is null");
            }

            actual.Name = item.Name;
        }
    }
}
