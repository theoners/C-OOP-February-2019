using System;

namespace _03.Ferrari
{
    public class StartUp
    {
        public static void Main()
        {
            var driver = Console.ReadLine();

            var ferrari = new Ferrari(driver);

            Console.WriteLine(ferrari);

        }
    }
}
