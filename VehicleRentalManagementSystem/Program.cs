namespace VehicleRentalManagementSystem 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating a new instance of RentalAgency with a fleet capacity of 10 vehicles
            RentalAgency agency = new RentalAgency(10);

            // Creating car objects
            Car car1 = new Car
            {
                Model = "Camry",
                Manufacturer = "Toyota",
                Year = 2023,
                RentalPrice = 50,
                Seats = 5,
                EngineType = "V6",
                Transmission = "Automatic",
                Convertible = false
            };

            Car car2 = new Car
            {
                Model = "Altima",
                Manufacturer = "Nissan",
                Year = 2023,
                RentalPrice = 45,
                Seats = 5,
                EngineType = "V6",
                Transmission = "Automatic",
                Convertible = false
            };

            // Creating a truck object
            Truck truck1 = new Truck
            {
                Model = "F-150",
                Manufacturer = "Ford",
                Year = 2022,
                RentalPrice = 80,
                Capacity = 2,
                TruckType = "Pickup",
                FourWheelDrive = true
            };

            // Creating motorcycle objects
            Motorcycle bike1 = new Motorcycle
            {
                Model = "Ninja",
                Manufacturer = "Kawasaki",
                Year = 2021,
                RentalPrice = 40,
                EngineCapacity = 1000,
                FuelType = "Gasoline",
                HasFairing = true
            };

            Motorcycle bike2 = new Motorcycle
            {
                Model = "R6",
                Manufacturer = "Yamaha",
                Year = 2021,
                RentalPrice = 80,
                EngineCapacity = 1000,
                FuelType = "Gasoline",
                HasFairing = true
            };

            // Adding vehicles to the rental agency's fleet
            agency.AddVehicle(car1);
            agency.AddVehicle(car2);
            agency.AddVehicle(truck1);
            agency.AddVehicle(bike1);
            agency.AddVehicle(bike2);

            // Displaying vehicle details in the fleet
            foreach (var vehicle in agency.Fleet)
            {
                if (vehicle != null)
                {
                    vehicle.DisplayDetails();
                    Console.WriteLine("\n");
                }
            }

            // Renting a vehicle
            agency.RentVehicle(car1, 5); // Renting a car for 5 days
            agency.RentVehicle(bike2, 2); // Renting a motorcycle for 2 days

            // Displaying total revenue earned by the rental agency
            Console.WriteLine($"Total Revenue: ${agency.TotalRevenue}");
        }
    }
}