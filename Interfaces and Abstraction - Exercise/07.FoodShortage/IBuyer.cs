namespace _07.FoodShortage
{
    public interface IBuyer
    {
        string Name { get; set; }

        int Age { get; }

        int Food { get; set; }

        void BuyFood();
    }
}
