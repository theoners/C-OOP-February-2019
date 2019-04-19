namespace _05.Mordor_sCruelPlan
{
    using Moods;

    using System;
    using System.Linq;

   public class StartUp
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var foods = input.Select(FoodFactory.GetFood).ToList();

            var happiness = foods.Sum(h => h.Happiness);
            Console.WriteLine(happiness);
            Console.WriteLine(new Mood(happiness).ToString());

        }
    }
}
