using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalManagementSystem
{
    public class Car : Vehicle
    {
        public int Seats { get; set; }
        public string? EngineType { get; set; }
        public string? Transmission { get; set; }
        public bool Convertible { get; set; }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Car Model: {Model}");
            Console.WriteLine($"Manufacturer: {Manufacturer}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Rental Price: ${RentalPrice}");
            Console.WriteLine($"Seats: {Seats}");
            Console.WriteLine($"Engine Type: {EngineType}");
            Console.WriteLine($"Transmission: {Transmission}");
            Console.WriteLine($"Convertible: {(Convertible ? "Yes" : "No")}");
        }
    }
}
