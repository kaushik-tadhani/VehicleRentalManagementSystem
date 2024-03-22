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
            throw new NotImplementedException();
        }
    }
}
