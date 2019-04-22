namespace _07.FoodShortage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var buyer = new List<IBuyer>();

            while (true)
            {
                var input = Console.ReadLine().Split();

                if (input[0]=="End")
                {
                    break;
                }

                switch (input.Length)
                {
                    case 4:
                    {
                        var person = new Citizen(input[0],int.Parse(input[1]),input[2],input[3]);
                        buyer.Add(person);
                        break;
                    }
                    case 3:
                    {
                        var rebel = new Rebel(input[0], int.Parse(input[1]), input[2]);
                        buyer.Add(rebel);
                        break;
                    }
                    default:
                        buyer.FirstOrDefault(x => x.Name == input[0])?.BuyFood();
                        break;
                }
            }

            Console.WriteLine(buyer.Sum(x=>x.Food));
        }
    }
}
