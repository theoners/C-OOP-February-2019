using System;

namespace _4.HotelReservation
{
    public class Startup
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var pricePerDay = double.Parse(input[0]);
            var numberOfDays = int.Parse(input[1]);
            var season = Enum.Parse<Season>(input[2]);
            var discount = DiscountType.None;

            if (input.Length==4)
            {
                discount = Enum.Parse<DiscountType>(input[3]);
            }

            var priceCalculator = new PriceCalculator(pricePerDay, numberOfDays, season, discount);

            var price = priceCalculator.CalculatePrice();

            Console.WriteLine($"{price:F2}");
        }
    }
}
