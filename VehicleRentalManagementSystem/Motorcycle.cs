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
            throw new NotImplementedException();
        }
    }
}
