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
            throw new NotImplementedException();
        }
    }
}
