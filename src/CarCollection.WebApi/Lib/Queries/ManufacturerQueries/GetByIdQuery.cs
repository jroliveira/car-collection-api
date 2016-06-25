using System.Linq;
using CarCollection.WebApi.Lib.Collections;
using CarCollection.WebApi.Models;

namespace CarCollection.WebApi.Lib.Queries.ManufacturerQueries
{
    public class GetByIdQuery : IQuery<Manufacturer>
    {
        private readonly ManufacturerCollection _collection;

        public int Id { get; set; }

        protected GetByIdQuery()
        {

        }

        public GetByIdQuery(ManufacturerCollection collection)
        {
            _collection = collection;
        }

        public virtual Manufacturer GetResult()
        {
            return _collection.FirstOrDefault(item => item.Id == Id);
        }
    }
}
