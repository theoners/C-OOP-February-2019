using System;

namespace _02.VehiclesExtension
{
    public abstract class Vehicle
    {
        private double fuelQuantity;

        protected Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            this.TankCapacity = tankCapacity;
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public double FuelQuantity
        {
            get => this.fuelQuantity;
            set
            {
                if (value>this.TankCapacity)
                {
                    this.fuelQuantity = 0;
                }
                else
                {
                    this.fuelQuantity = value;
                }
            }
        }

        public double FuelConsumption { get; set; }

        public double TankCapacity { get; set; }

        public virtual void Refuel(double amount)
        {
            if (amount<=0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            if (this.TankCapacity<this.FuelQuantity+amount)
            {
                throw new ArgumentException($"Cannot fit {amount} fuel in the tank");
               
            }

            FuelQuantity += amount;
        }

        public string Drive(double distance)
        {
            if (this.FuelQuantity >= this.FuelConsumption * distance)
            {
                this.FuelQuantity -= this.FuelConsumption * distance;
                return $"{this.GetType().Name} travelled {distance} km";
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
