namespace _03.Ferrari
{
    public class Ferrari:ICar
    {
        public Ferrari( string driver)
        {
            this.Model = "488-Spider";
            this.Driver = driver;
        }

        public string Model { get;}

        public string Driver { get; set; }

        public string Gas()
        {
            return "Gas!";
        }

        public string Brakes()
        {
            return "Brakes!";
        }

        public override string ToString()
        {
            return $"{this.Model}/{this.Brakes()}/{this.Gas()}/{this.Driver}";
        }
    }
}
