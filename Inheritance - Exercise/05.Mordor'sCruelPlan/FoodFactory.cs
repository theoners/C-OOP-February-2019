namespace _05.Mordor_sCruelPlan
{
    using _05.Mordor_sCruelPlan.Foods;

    public class FoodFactory
    {
        public static Food GetFood(string foodName)
        {
            switch (foodName.ToLower())
            {
                case "apple":
                    return new Apple();
                case "cram":
                    return new Cram();
                case "honeycake":
                    return new HoneyCake();
                case "lembas":
                    return new Lembas();
                case "melon":
                    return new Melon();
                case "mushrooms":
                    return new Mushrooms();
                default:
                    return new OtherFood();
            }
        }
    }
}
