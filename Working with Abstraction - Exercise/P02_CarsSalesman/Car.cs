using System.Text;

namespace P02_CarsSalesman
{
    public class Car
    {
        private const string offset = "  ";

        private string model;
        private Engine engine;
        private int weight;
        private string color;

        public Car(string model, Engine engine)
        {
            this.model = model;
            this.engine = engine;
            this.weight = -1;
            this.color = "n/a";
        }

        public Car(string model, Engine engine, int weight)
        {
            this.model = model;
            this.engine = engine;
            this.weight = weight;
            this.color = "n/a";
        }

        public Car(string model, Engine engine, string color)
        {
            this.model = model;
            this.engine = engine;
            this.weight = -1;
            this.color = color;
        }

        public Car(string model, Engine engine, int weight, string color)
        {
            this.model = model;
            this.engine = engine;
            this.weight = weight;
            this.color = color;
        }


        public override string ToString()
        {
            var carInfo = new StringBuilder();
            carInfo.AppendFormat("{0}:\n", this.model);
            carInfo.Append(this.engine.ToString());
            carInfo.AppendFormat("{0}Weight: {1}\n", offset, this.weight == -1 ? "n/a" : this.weight.ToString());
            carInfo.AppendFormat("{0}Color: {1}", offset, this.color);

            return carInfo.ToString();
        }
    }
}
