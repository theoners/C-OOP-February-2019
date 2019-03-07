namespace P01_RawData
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RawData
    {
        public static void Main()
        {
            var cars = new List<Car>();
            var lines = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                var parameters = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var model = parameters[0];
                var engineSpeed = int.Parse(parameters[1]);
                var enginePower = int.Parse(parameters[2]);

                var engine = new Engine(engineSpeed,enginePower);

                var cargoWeight = int.Parse(parameters[3]);
                var cargoType = parameters[4];

                var cargo = new Cargo(cargoWeight,cargoType);

                var tires = new List<Tire>();
                for (int j = 5; j <= 12; j+=2)
                {
                    var pressure = double.Parse(parameters[j]);
                    var age = int.Parse(parameters[j+1]);

                    var tire = new Tire(age,pressure);
                    tires.Add(tire);
                }
              
                cars.Add(new Car(model, engine, cargo, tires));
            }
            var command = Console.ReadLine();
            if (command == "fragile")
            {
                foreach (var car in cars.Where(x => x.Cargo.CargoType == command && x.Tires.Any(y => y.Pressure < 1)))
                {
                    Console.WriteLine($"{car.Model}");
                }
            }
            else
            {
                foreach (var car in cars.Where(x => x.Cargo.CargoType == command && x.Engine.EnginePower > 250))
                {
                    Console.WriteLine($"{car.Model}");
                }
            }
        }
    }
}
