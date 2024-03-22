using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalManagementSystem
{
    public class RentalAgency
    {
        public Vehicle[] Fleet { get; set; }
        public decimal TotalRevenue { get; set; }

        public RentalAgency(int arrayCapacity)
        {
            Fleet = new Vehicle[arrayCapacity];
        }

        public void AddVehicle(Vehicle vehicle)
        {
            for (int i = 0; i < Fleet.Length; i++)
            {
                if (Fleet[i] == null)
                {
                    Fleet[i] = vehicle;
                    break;
                }
            }
        }

        public void RemoveVehicle(Vehicle vehicle)
        {
            for (int i = 0; i < Fleet.Length; i++)
            {
                if (Fleet[i] == vehicle)
                {
                    // Shift elements to the left
                    for (int j = i; j < Fleet.Length - 1; j++)
                    {
                        Fleet[j] = Fleet[j + 1];
                    }

                    // Set the last element to null
                    Fleet[Fleet.Length - 1] = null;
                    break;
                }
            }
        }

        public void RentVehicle(Vehicle vehicle, int days)
        {
            if (vehicle == null)
            {
                Console.WriteLine("Vehicle not found in fleet.");
                return;
            }

            decimal rentalCost = vehicle.RentalPrice * days;
            TotalRevenue += rentalCost;

            Console.WriteLine($"Vehicle rented for {days} days:");
            vehicle.DisplayDetails();
            Console.WriteLine($"Total cost: ${rentalCost}\n");
        }
    }
}
