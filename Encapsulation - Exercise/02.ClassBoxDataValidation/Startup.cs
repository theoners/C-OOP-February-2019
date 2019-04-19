using System;

namespace _02.ClassBoxDataValidation
{
    public class Startup
    {
        public static void Main()
        {
            var length = double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
           
            try
            {
                var box = new Box(length, width, height);
                Console.WriteLine($"Surface Area - {box.CalculateSurfaceArea():F2}");
                Console.WriteLine($"Lateral Surface Area - {box.CalculateLateralSurfaceArea():F2}");
                Console.WriteLine($"Volume - {box.CalculateVolume():F2}");
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
            }

            

        }
    }
}
