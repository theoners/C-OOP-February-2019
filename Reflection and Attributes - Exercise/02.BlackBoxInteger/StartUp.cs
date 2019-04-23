namespace _02.BlackBoxInteger
{
    using System;
    using System.Reflection;

    public static class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var type = typeof(BlackBoxInteger);
            var classInstance = (BlackBoxInteger)Activator.CreateInstance(type, true);

            while (input != "END")
            {
                var methodName = input.Split("_")[0];
                var number = int.Parse(input.Split("_")[1]);

                var method = type.GetMethod(methodName, BindingFlags.Instance | BindingFlags.NonPublic);

                method.Invoke(classInstance, new object[] { number });
                var value = type.GetField("innerValue", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(classInstance);

                Console.WriteLine(value);
                input = Console.ReadLine();
            }
        }
    }
}
