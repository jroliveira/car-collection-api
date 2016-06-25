using System.Collections.Generic;
using CarCollection.WebApi.Lib.Collections;
using CarCollection.WebApi.Models;

namespace CarCollection.WebApi.Lib.Queries.ManufacturerQueries
{
    public class GetAllQuery : IQuery<IEnumerable<Manufacturer>>
    {
        private readonly ManufacturerCollection _collection;

        public int Id { get; set; }

        protected GetAllQuery()
        {

        }

        public GetAllQuery(ManufacturerCollection collection)
        {
            _collection = collection;
        }

        public virtual IEnumerable<Manufacturer> GetResult()
        {
            return _collection;
        }
    }
}