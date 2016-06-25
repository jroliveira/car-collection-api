namespace CarCollection.WebApi.Models
{
    public class Vehicle : ModelBase<int>
    {
        public string Model { get; set; }
        public string Note { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public VehicleType Type { get; set; }
    }
}
