using System.Collections.Generic;

namespace CarCollection.WebApi.Models
{
    public class TestDrive : ModelBase<int>
    {
        public IEnumerable<Vehicle> Vehicles { get; set; }
    }
}