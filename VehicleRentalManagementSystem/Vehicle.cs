using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalManagementSystem
{
    public abstract class Vehicle
    {
        public string? Model { get; set; }
        public string? Manufacturer { get; set; }
        public int Year { get; set; }
        public decimal RentalPrice { get; set; }

        public abstract void DisplayDetails();
    }
}
