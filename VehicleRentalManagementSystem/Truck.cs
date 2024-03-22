using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalManagementSystem
{
    public class Truck : Vehicle
    {
        public int Capacity { get; set; }
        public string? TruckType { get; set; }
        public bool FourWheelDrive { get; set; }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Truck Model: {Model}");
            Console.WriteLine($"Manufacturer: {Manufacturer}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Rental Price: ${RentalPrice}");
            Console.WriteLine($"Capacity: {Capacity}");
            Console.WriteLine($"Truck Type: {TruckType}");
            Console.WriteLine($"Four Wheel Drive: {(FourWheelDrive ? "Yes" : "No")}");
        }
    }
}
