namespace _02.VehiclesExtension
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var carInfo = Console.ReadLine().Split();
            var fuelQuantity = double.Parse(carInfo[1]);
            var fuelConsumption = double.Parse(carInfo[2]);
            var tankCapacity = double.Parse(carInfo[3]);
            var car = new Car(fuelQuantity, fuelConsumption,tankCapacity);

            var truckInfo = Console.ReadLine().Split();
            fuelQuantity = double.Parse(truckInfo[1]);
            fuelConsumption = double.Parse(truckInfo[2]);
            tankCapacity = double.Parse(truckInfo[3]);

            var truck = new Truck(fuelQuantity, fuelConsumption,tankCapacity);

            var busInfo = Console.ReadLine().Split();
            fuelQuantity = double.Parse(busInfo[1]);
            fuelConsumption = double.Parse(busInfo[2]);
            tankCapacity = double.Parse(busInfo[3]);

            var bus = new Bus(fuelQuantity,fuelConsumption,tankCapacity);

            var lineCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < lineCount; i++)
            {
                try
                {
                    var input = Console.ReadLine().Split();

                    var command = input[0];
                    var vehicleType = input[1];

                    if (command == "Drive")
                    {
                        var distance = double.Parse(input[2]);
                        if (vehicleType == "Car")
                        {
                            Console.WriteLine(car.Drive(distance));
                        }
                        else if (vehicleType == "Truck")
                        {
                            Console.WriteLine(truck.Drive(distance));
                        }
                        else
                        {
                            Console.WriteLine(bus.Drive(distance));
                        }
                    }
                    else if (command == "DriveEmpty")
                    {
                        var distance = double.Parse(input[2]);
                        Console.WriteLine(bus.EmptyDrive(distance));
                    }

                    else
                    {
                        var fuelAmount = double.Parse(input[2]);

                        if (vehicleType == "Car")
                        {
                            car.Refuel(fuelAmount);
                        }
                        else if (vehicleType == "Bus")
                        {
                            bus.Refuel(fuelAmount);
                        }
                        else
                        {
                            truck.Refuel(fuelAmount);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
              
            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
        }
    }
}
