namespace _03.WildFarm.Factory
{
    using Models.Foods;

    public abstract class FoodFactory
    {
        public static Food GetFood(string[] foodInfo)
        {
            var name = foodInfo[0].ToLower();
            var quantity = int.Parse(foodInfo[1]);

            switch (name)
            {
                case "fruit":
                    return new Fruit(quantity);
                case "meat":
                    return new Meat(quantity);
                case "seeds":
                    return new Seeds(quantity);
                case "vegetable":
                    return new Vegetable(quantity);
                default:
                    return null;
            }
        }
    }
}
