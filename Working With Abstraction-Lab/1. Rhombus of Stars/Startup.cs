using System;

namespace _1._Rhombus_of_Stars
{
    public class Startup
    {
        public static int n = int.Parse(Console.ReadLine());

        public static void Main()
        {
            for (int row = 1; row <= n; row++)
            {
                PrintRow(row);
            }

            for (int row = n - 1; row > 0; row--)
            {
                PrintRow(row);
            }
        }

        public static void PrintRow(int row)
        {
            for (int col = 0; col < n - row; col++)
            {
                Console.Write(" ");
            }

            for (int col = 1; col < row; col++)
            {
                Console.Write("* ");
            }

            Console.WriteLine("*");
        }
    }
}
