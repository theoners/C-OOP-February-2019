namespace P01_RawData
{
    public class Tire
    {
        private int year;

        public Tire(int year, double pressure)
        {
            this.year = year;
            this.Pressure = pressure;
        }

        public double Pressure { get; }
    }
}
