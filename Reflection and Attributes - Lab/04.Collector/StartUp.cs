using System;

namespace _04.Collector
{
   public static class StartUp
    {
        public static void Main()
        {
            var spy = new Spy();
            var result = spy.CollectGettersAndSetters("Hacker");
            Console.WriteLine(result);
        }
    }
}
