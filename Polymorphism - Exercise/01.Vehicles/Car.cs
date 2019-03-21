namespace _01.Vehicles
{
    public class Car:Vehicle
    {
        private const double AirConditioner = 0.9;

        public Car(double fuelQuantity, double fuelConsumption) 
            : base(fuelQuantity, fuelConsumption+AirConditioner)
        {
        }
    }
}
