using System.Linq;

namespace _2._Point_in_Rectangle
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var coordinatesOfRectangle = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            var topLeftX = coordinatesOfRectangle[0];
            var topLeftY = coordinatesOfRectangle[1];

            var topLeftPoint = new Point(topLeftX, topLeftY);

            var bottomRightX = coordinatesOfRectangle[2];
            var bottomRightY = coordinatesOfRectangle[3];

            var bottomRightPoint = new Point(bottomRightX, bottomRightY);
            var rectangle = new Rectangle(topLeftPoint, bottomRightPoint);

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var pointCoordinates = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
                var pointX = pointCoordinates[0];
                var pointY = pointCoordinates[1];

                var point = new Point(pointX,pointY);

                Console.WriteLine(rectangle.Contains(point));
            }
        }
    }
}
