namespace _03.WildFarm.Models.Animals
{
    using System;
    using Foods;

    public class Tiger:Feline
    {
        private const double WeightPerFood = 1.00;

        public Tiger(string name, double weight, string livingRegion, string breed) 
            : base(name, weight,  livingRegion, breed)
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
            return $"ROAR!!!";
        }
    }
}
