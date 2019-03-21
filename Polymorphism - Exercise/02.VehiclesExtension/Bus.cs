namespace _02.VehiclesExtension
{
    public class Bus:Vehicle
    {
        private const double AirConditioner = 1.4;

        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity) 
            : base(fuelQuantity, fuelConsumption+AirConditioner, tankCapacity)
        {
        }

        public string EmptyDrive(double distance)
        {
            this.FuelConsumption -= AirConditioner;
            return base.Drive(distance);
        }
    }
}
