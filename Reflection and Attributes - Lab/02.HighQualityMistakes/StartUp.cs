    using System;

    public static class StartUp
    {
        public static void Main()
        {
            var spy = new Spy();
            var result = spy.AnalyzeAcessModifiers("Hacker");
            Console.WriteLine(result);
        }
    }
