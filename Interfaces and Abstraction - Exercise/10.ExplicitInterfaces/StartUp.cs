namespace _10.ExplicitInterfaces
{
    using System;
    using Contracts;

    public class StartUp
    {
       public static void Main()
        {
            while (true)
            {
                var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (input[0]=="End")
                {
                    break;
                }

                var name = input[0];
                var country = input[1];
                var age = int.Parse(input[2]);

                IPerson citizen = new Citizen(name,country,age);
                Console.WriteLine(citizen.GetName());
                Console.WriteLine(((IResident)citizen).GetName());
            }
        }
    }
}
