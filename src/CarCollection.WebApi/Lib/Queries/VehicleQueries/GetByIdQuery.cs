using System.Linq;
using CarCollection.WebApi.Lib.Collections;
using CarCollection.WebApi.Models;

namespace CarCollection.WebApi.Lib.Queries.VehicleQueries
{
    public class GetByIdQuery : IQuery<Vehicle>
    {
        private readonly VehicleCollection _collection;

        public int Id { get; set; }

        protected GetByIdQuery()
        {

        }

        public GetByIdQuery(VehicleCollection collection)
        {
            _collection = collection;
        }

        public virtual Vehicle GetResult()
        {
            return _collection.FirstOrDefault(item => item.Id == Id);
        }
    }
}
