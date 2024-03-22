namespace VehicleRentalManagementSystem 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RentalAgency agency = new RentalAgency(10);

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

            agency.AddVehicle(car1);
            agency.AddVehicle(car2);
            agency.AddVehicle(truck1);
            agency.AddVehicle(bike1);
            agency.AddVehicle(bike2);

            // Displaying vehicle details
            foreach (var vehicle in agency.Fleet)
            {
                if (vehicle != null)
                {
                    vehicle.DisplayDetails();
                    Console.WriteLine("\n");
                }
            }

            // Renting a vehicle
            agency.RentVehicle(car1, 5);
            agency.RentVehicle(bike2, 2);

            // Displaying total revenue
            Console.WriteLine($"Total Revenue: ${agency.TotalRevenue}");
        }
    }
}