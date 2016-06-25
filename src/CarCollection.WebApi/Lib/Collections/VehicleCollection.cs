using System.Collections;
using System.Collections.Generic;
using System.Linq;
using CarCollection.WebApi.Models;

namespace CarCollection.WebApi.Lib.Collections
{
    public class VehicleCollection : ICollection<Vehicle>
    {
        private static readonly List<Vehicle> Vehicles;

        static VehicleCollection()
        {
            Vehicles = new List<Vehicle>
            {
                new Vehicle
                {
                    Id = 1,
                    Model = "Gol",
                    Note = "Excelente para o dia a dia.",
                    Type = VehicleType.Hatchback,
                    Manufacturer = new Manufacturer
                    {
                        Id = 3,
                        Name = "Volkswagen"
                    }
                },
                new Vehicle
                {
                    Id = 2,
                    Model = "Jetta",
                    Note = "Reflete elegância, charme e um toque acentuado de esportividade em seu design.",
                    Type = VehicleType.Sedan,
                    Manufacturer = new Manufacturer
                    {
                        Id = 3,
                        Name = "Volkswagen"
                    }
                },
                new Vehicle
                {
                    Id = 3,
                    Model = "500",
                    Note = "Fiat 500 tem um design inovador.",
                    Type = VehicleType.Hatchback,
                    Manufacturer = new Manufacturer
                    {
                        Id = 2,
                        Name = "Fiat"
                    }
                },
                new Vehicle
                {
                    Id = 5,
                    Model = "Toro",
                    Note = "Não tem melhor para o trabalho no campo.",
                    Type = VehicleType.Pickup,
                    Manufacturer = new Manufacturer
                    {
                        Id = 2,
                        Name = "Fiat"
                    }
                },
                new Vehicle
                {
                    Id = 4,
                    Model = "Cruze",
                    Note = "O Cruze Sport6 é um hatch esportivo que arranca olhares por onde passa.",
                    Type = VehicleType.Sport,
                    Manufacturer = new Manufacturer
                    {
                        Id = 1,
                        Name = "Chevrolet"
                    }
                },
                new Vehicle
                {
                    Id = 6,
                    Model = "Prisma",
                    Note = "Tem muito espaço, tecnologia, conectividade e conforto.",
                    Type = VehicleType.Sedan,
                    Manufacturer = new Manufacturer
                    {
                        Id = 1,
                        Name = "Chevrolet"
                    }
                }
            };
        }

        public IEnumerator<Vehicle> GetEnumerator()
        {
            return Vehicles.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(Vehicle item)
        {
            var id = Vehicles.Max(vehicle => vehicle.Id) + 1;
            item.Id = (short) id;

            Vehicles.Add(item);
        }

        public void Clear()
        {
            Vehicles.Clear();
        }

        public bool Contains(Vehicle item)
        {
            return Vehicles.Contains(item);
        }

        public void CopyTo(Vehicle[] array, int arrayIndex)
        {
            Vehicles.CopyTo(array, arrayIndex);
        }

        public bool Remove(Vehicle item)
        {
            return Vehicles.Remove(item);
        }

        public int Count => Vehicles.Count;
        public bool IsReadOnly => false;
    }
}
