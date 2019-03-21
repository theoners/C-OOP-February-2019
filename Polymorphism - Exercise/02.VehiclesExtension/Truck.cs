namespace _02.VehiclesExtension
{
   public class Truck: Vehicle
    {
        private const double AirConditioner = 1.6;

        public override void Refuel(double amount)
        {
            base.Refuel(amount);
            this.FuelQuantity -= amount * 0.05;
        }


        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity) 
            : base(fuelQuantity, fuelConsumption+AirConditioner, tankCapacity)
        {
        }
    }
}
