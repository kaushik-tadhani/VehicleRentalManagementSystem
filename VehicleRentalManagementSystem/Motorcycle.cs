using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalManagementSystem
{
    public class Motorcycle : Vehicle
    {
        public int EngineCapacity { get; set; }
        public string? FuelType { get; set; }
        public bool HasFairing { get; set; }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Motorcycle Model: {Model}");
            Console.WriteLine($"Manufacturer: {Manufacturer}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Rental Price: ${RentalPrice}");
            Console.WriteLine($"Engine Capacity: {EngineCapacity}");
            Console.WriteLine($"Fuel Type: {FuelType}");
            Console.WriteLine($"Has Fairing: {(HasFairing ? "Yes" : "No")}");
        }
    }
}
