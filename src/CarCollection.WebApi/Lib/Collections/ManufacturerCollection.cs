using System.Collections;
using System.Collections.Generic;
using System.Linq;
using CarCollection.WebApi.Models;

namespace CarCollection.WebApi.Lib.Collections
{
    public class ManufacturerCollection : ICollection<Manufacturer>
    {
        private static readonly List<Manufacturer> Manufacturers;

        static ManufacturerCollection()
        {
            Manufacturers = new List<Manufacturer>
            {
                new Manufacturer { Id = 1, Name = "Chevrolet" },
                new Manufacturer { Id = 2, Name = "Fiat" },
                new Manufacturer { Id = 3, Name = "Volkswagen" }
            };
        }

        public IEnumerator<Manufacturer> GetEnumerator()
        {
            return Manufacturers.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(Manufacturer item)
        {
            var id = Manufacturers.Max(manufacturer => manufacturer.Id) + 1;
            item.Id = (short) id;

            Manufacturers.Add(item);
        }

        public void Clear()
        {
            Manufacturers.Clear();
        }

        public bool Contains(Manufacturer item)
        {
            return Manufacturers.Contains(item);
        }

        public void CopyTo(Manufacturer[] array, int arrayIndex)
        {
            Manufacturers.CopyTo(array, arrayIndex);
        }

        public bool Remove(Manufacturer item)
        {
            return Manufacturers.Remove(item);
        }

        public int Count => Manufacturers.Count;
        public bool IsReadOnly => false;
    }
}
