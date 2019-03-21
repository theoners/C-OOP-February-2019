namespace _03.WildFarm.Models.Animals
{
    using Foods;
    using System;

    public class Owl:Bird
    {
        private const double WeightPerFood = 0.25;

        public Owl(string name, double weight,  double wingSize) 
            : base(name, weight, wingSize)
        {
        }

        public override void Eat(Food food)
        {
            if (food is Meat)
            {
                this.Weight += food.Quantity * WeightPerFood;
                this.FoodEaten += food.Quantity;
            }
            else
            {
                throw new ArgumentException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }
        }

        public override string Sound()
        {
            return $"Hoot Hoot";
        }
    }
}
