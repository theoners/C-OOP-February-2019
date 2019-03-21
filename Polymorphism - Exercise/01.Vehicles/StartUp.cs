namespace _01.Vehicles
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var carInfo = Console.ReadLine().Split();
            var fuelQuantity = double.Parse(carInfo[1]);
            var fuelConsumption = double.Parse(carInfo[2]);

            var car  = new Car(fuelQuantity, fuelConsumption);

            var truckInfo = Console.ReadLine().Split();
            fuelQuantity = double.Parse(truckInfo[1]);
            fuelConsumption = double.Parse(truckInfo[2]);

            var truck = new Truck(fuelQuantity, fuelConsumption);

            var lineCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < lineCount; i++)
            {
                var input = Console.ReadLine().Split();

                var command = input[0];
                var vehicleType = input[1];

                if (command=="Drive")
                {
                    var distance = double.Parse(input[2]);
                    Console.WriteLine(vehicleType == "Car" ? car.Drive(distance) : truck.Drive(distance));
                }
                else
                {
                    var fuelAmount = double.Parse(input[2]);

                    if (vehicleType == "Car")
                    {
                        car.Refuel(fuelAmount);
                    }
                    else
                    {
                        truck.Refuel(fuelAmount);
                    }
                }
            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
        }
    }
}
