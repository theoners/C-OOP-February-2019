namespace _03.WildFarm.Models.Animals
{
    using Foods;

    public abstract class Animal
    {
        protected Animal(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
            this.FoodEaten = 0;
        }

        public string Name { get; set; }

        public double Weight { get; set; }

        public int FoodEaten { get; set; }


        public abstract void Eat(Food food);

        public abstract string Sound();

    }
}
