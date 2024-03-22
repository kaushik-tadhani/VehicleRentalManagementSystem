using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalManagementSystem
{
    public class RentalAgency
    {
        // Array to store the fleet of vehicles
        public Vehicle[] Fleet { get; set; }

        // Total revenue earned by the rental agency
        public decimal TotalRevenue { get; set; }

        /// <summary>
        /// Constructor to initialize the fleet array with the specified capacity
        /// </summary>
        /// <param name="arrayCapacity">Array capacity for fleet</param>
        public RentalAgency(int arrayCapacity)
        {
            Fleet = new Vehicle[arrayCapacity];
        }

        /// <summary>
        /// Method to add a vehicle to the fleet
        /// </summary>
        /// <param name="vehicle">Vehicle class object to be add</param>
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

        /// <summary>
        /// Method to remove a vehicle from the fleet
        /// </summary>
        /// <param name="vehicle">Vehicle class object to be remove</param>
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

        /// <summary>
        ///  Method to rent a vehicle for a specified number of days
        /// </summary>
        /// <param name="vehicle">Vehicle class object to be rented</param>
        /// <param name="days">Number of day for rent</param>
        public void RentVehicle(Vehicle vehicle, int days)
        {
            if (vehicle == null)
            {
                Console.WriteLine("Vehicle not found in fleet.");
                return;
            }

            // Calculate rental cost based on the vehicle's rental price and the number of days
            decimal rentalCost = vehicle.RentalPrice * days;
            TotalRevenue += rentalCost;

            // Display details of the rented vehicle and the total cost
            Console.WriteLine($"Vehicle rented for {days} days:");
            vehicle.DisplayDetails();
            Console.WriteLine($"Total cost: ${rentalCost}\n");
        }
    }
}
