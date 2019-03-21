namespace _01.Vehicles
{
   public class Vehicle
    {
        public Vehicle(double fuelQuantity, double fuelConsumption)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public double FuelQuantity { get; set; }

        public double FuelConsumption { get; set; }

        public virtual void Refuel(double amount)
        {
            FuelQuantity += amount;
        }

        public string Drive(double distance)
        {
            if (this.FuelQuantity>=FuelConsumption*distance)
            {
                FuelQuantity -= FuelConsumption * distance;
                return$"{this.GetType().Name} travelled {distance} km";
            }
            else
            {
                return $"{this.GetType().Name} needs refueling";
            }
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:F2}";
        }
    }
}
