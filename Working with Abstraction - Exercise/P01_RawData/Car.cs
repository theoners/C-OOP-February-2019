namespace P01_RawData
{
    using System.Collections.Generic;

    public class Car
    {
        public Car(string model, Engine engine, Cargo cargo, List<Tire> tires)
        {
            this.Model = model;
            this.Engine = engine;
            this.Cargo = cargo;
            this.Tires = tires ;
        }
        public string Model { get; }

        public Engine Engine { get; }

        public Cargo Cargo { get; }

        public List<Tire> Tires { get; }
    }
}
