namespace _04.BarrackWars_TheCommandsStrikeBack.Core
{
    using System.Globalization;
    using System.Reflection;
    using Commands;
    using System;
    using Contracts;

    class Engine : IRunnable
    {
        private IRepository repository;
        private IUnitFactory unitFactory;

        public Engine(IRepository repository, IUnitFactory unitFactory)
        {
            this.repository = repository;
            this.unitFactory = unitFactory;
        }

        public void Run()
        {
            while (true)
            {
                try
                {
                    string input = Console.ReadLine();
                    string[] data = input.Split();
                    string commandName = data[0];
                    string result = InterpredCommand(data, commandName);
                    Console.WriteLine(result);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        private string InterpredCommand(string[] data, string commandName)
        {
            Type type = Type.GetType($"{typeof(Command).Namespace}" +
                                     $".{CultureInfo.CurrentCulture.TextInfo.ToTitleCase(commandName.ToLower()) + "Command"}");

            Object instance = Activator.CreateInstance(type, new object[] { data, repository, unitFactory });
            try
            {
                MethodInfo command = type.GetMethod("Execute");
                string result = command.Invoke(instance, null).ToString();
                return result;
            }
            catch (Exception e)
            {
                return e.InnerException.Message;
            }
        }
    }
}
