namespace P04_Hospital
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            var doctors = new Dictionary<string, List<string>>();
            var departments = new Dictionary<string, List<List<string>>>();


            var command = Console.ReadLine();
            while (command != "Output")
            {
                var tokens = command.Split();
                var department = tokens[0];
                var firstName = tokens[1];
                var secondName = tokens[2];
                var patient = tokens[3];
                var fullName = firstName +" "+ secondName;

                if (!doctors.ContainsKey(fullName))
                {
                    doctors[fullName] = new List<string>();
                }
                if (!departments.ContainsKey(department))
                {
                    departments[department] = new List<List<string>>();
                    for (int rooms = 0; rooms < 20; rooms++)
                    {
                        departments[department].Add(new List<string>());
                    }
                }

                bool havePlace = departments[department].SelectMany(x => x).Count() < 60;
                if (havePlace)
                {
                    int room = 0;
                    doctors[fullName].Add(patient);
                    for (int st = 0; st < departments[department].Count; st++)
                    {
                        if (departments[department][st].Count < 3)
                        {
                            room = st;
                            break;
                        }
                    }
                    departments[department][room].Add(patient);
                }

                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            while (command != "End")
            {
                var args = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (args.Length == 1)
                {
                    Console.WriteLine(string.Join("\n", departments[args[0]].Where(x => x.Count > 0).SelectMany(x => x)));
                }
                else if (args.Length == 2 && int.TryParse(args[1], out var room))
                {
                    Console.WriteLine(string.Join("\n", departments[args[0]][room - 1].OrderBy(x => x)));
                }
                else
                {
                    Console.WriteLine(string.Join("\n", doctors[args[0] +" "+ args[1]].OrderBy(x => x)));
                }
                command = Console.ReadLine();
            }
        }
    }
}
