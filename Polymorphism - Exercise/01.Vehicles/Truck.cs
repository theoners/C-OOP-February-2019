namespace _01.Vehicles
{
   public class Truck: Vehicle
    {
        private const double AirConditioner = 1.6;

        public override void Refuel(double amount)
        {
            this.FuelQuantity += amount * 0.95;
        }

        public Truck(double fuelQuantity, double fuelConsumption) 
            : base(fuelQuantity, fuelConsumption+AirConditioner)
        {
        }
    }
}
