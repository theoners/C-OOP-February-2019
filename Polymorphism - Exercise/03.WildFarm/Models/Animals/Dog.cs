using _03.WildFarm.Models.Foods;

namespace _03.WildFarm.Models.Animals
{
    using System;

    public class Dog:Mammal
    {
        private const double WeightPerFood = 0.40;

        public Dog(string name, double weight, string livingRegion)
            : base(name, weight, livingRegion)
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
            return $"Woof!";
        }
    }
}
