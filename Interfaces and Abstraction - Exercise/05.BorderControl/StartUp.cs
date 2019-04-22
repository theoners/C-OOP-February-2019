namespace _05.BorderControl
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var entered = new List<Entered>();
            while (true)
            {
                var input = Console.ReadLine().Split();

                if (input[0]=="End")
                {
                    break;
                }
                if (input.Length==3)
                {
                    var citizen = new Citizen(input[0],int.Parse(input[1]),input[2]);
                    entered.Add(citizen);
                }
                else
                {
                    var robot = new Robot(input[0],input[1]);
                    entered.Add(robot);
                }
            }

            var lastDigits = Console.ReadLine();

            foreach (var id in entered.Where(x=>x.Id.EndsWith(lastDigits)))
            {
                Console.WriteLine(id.Id);
            }
        }
    }
}

