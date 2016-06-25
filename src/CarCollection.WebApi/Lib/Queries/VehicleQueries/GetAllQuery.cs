using System.Collections.Generic;
using CarCollection.WebApi.Lib.Collections;
using CarCollection.WebApi.Models;

namespace CarCollection.WebApi.Lib.Queries.VehicleQueries
{
    public class GetAllQuery : IQuery<IEnumerable<Vehicle>>
    {
        private readonly VehicleCollection _collection;

        public int Id { get; set; }

        protected GetAllQuery()
        {

        }

        public GetAllQuery(VehicleCollection collection)
        {
            _collection = collection;
        }

        public virtual IEnumerable<Vehicle> GetResult()
        {
            return _collection;
        }
    }
}