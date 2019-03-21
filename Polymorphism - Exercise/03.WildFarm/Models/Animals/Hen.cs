namespace _03.WildFarm.Models.Animals
{
    using Foods;

    public class Hen:Bird
    {
        private const double WeightPerFood = 0.35;

        public Hen(string name, double weight, double wingSize) 
            : base(name, weight, wingSize)
        {
        }

        public override string Sound()
        {
            return $"Cluck";
        }

        public override void Eat(Food food)
        {
            this.Weight += WeightPerFood * food.Quantity;
            this.FoodEaten += food.Quantity;
        }
    }
}
