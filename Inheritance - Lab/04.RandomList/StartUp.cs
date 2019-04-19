namespace CustomRandomList
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var randomList = new RandomList { "1", "2", "3", "4", "5" };
            Console.WriteLine(randomList.RandomString());
        }
    }
}
