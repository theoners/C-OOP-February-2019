namespace _03.WildFarm.Models.Animals
{
    using Foods;

    using System;

    public class Mouse:Mammal
    {
        private const double WeightPerFood = 0.10;

        public Mouse(string name, double weight, string livingRegion) 
            : base(name, weight, livingRegion)
        {
        }

        public override string Sound()
        {
            return $"Squeak";
        }

        public override void Eat(Food food)
        {
            var foodType = food.GetType().Name.ToLower();
            if (foodType== "vegetable" || foodType== "fruit")
            {
                this.Weight += WeightPerFood * food.Quantity;
                this.FoodEaten += food.Quantity;
            }
            else
            {
                throw new ArgumentException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }
        }
    }
}
