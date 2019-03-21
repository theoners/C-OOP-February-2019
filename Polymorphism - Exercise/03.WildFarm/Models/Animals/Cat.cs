namespace _03.WildFarm.Models.Animals
{
    using System;
    using Foods;

    public class Cat:Feline
    {
        private const double WeightPerFood = 0.30;

        public Cat(string name, double weight,  string livingRegion, string breed) 
            : base(name, weight, livingRegion, breed)
        {
        }

        public override void Eat(Food food)
        {
            var foodType = food.GetType().Name.ToLower();

            if (foodType=="vegetable" || foodType=="meat")
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
            return $"Meow";
        }
    }
}
