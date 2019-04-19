using System;

namespace _01._Class_Box
{
    public class Startup
    {
        public static void Main()
        {
            var length = double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            var box = new Box(length,width,height);

            Console.WriteLine($"Surface Area - {box.CalculateSurfaceArea():F2}");
            Console.WriteLine($"Lateral Surface Area - {box.CalculateLateralSurfaceArea():F2}");
            Console.WriteLine($"Volume - {box.CalculateVolume():F2}");
        }
    }
}
