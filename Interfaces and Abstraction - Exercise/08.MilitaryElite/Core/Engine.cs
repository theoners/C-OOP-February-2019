namespace _08.MilitaryElite.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Factories;
    using Models;

    public class Engine
    {
        public void Run()
        {
            var privateFactory = new PrivateFactory();
            var commandoFactory = new CommandoFactory();
            var missionFactory = new MissionFactory();
            var engineerFactory = new EngineerFactory();
            var lieutenantGeneralFactory = new LieutenantGeneralFactory();
            var spyFactory = new SpyFactory();
            var repairFactory = new RepairFactory();

            var soldiers = new List<Soldier>();

            while (true)
            {
                var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var command = input[0];
                if (command=="End")
                {
                    break;
                }

                try
                {
                    switch (command)
                    {
                        case "Private":
                            var privateSoldier = privateFactory.CreatePrivate(input);
                            soldiers.Add(privateSoldier);
                            break;
                        case "Commando":
                            var commando = commandoFactory.CreateCommando(input);
                            for (int i = 6; i < input.Length; i+=2)
                            {
                                var codeName = input[i];
                                var state = input[i + 1];
                                var mission = missionFactory.CreateMission(codeName, state);
                                commando.AddMission(mission);
                            }
                            soldiers.Add(commando);
                            break;
                        case "LieutenantGeneral":
                            var lieutenantGeneral = lieutenantGeneralFactory.CreateLieutenantGeneral(input);
                            for (int i = 5; i < input.Length; i++)
                            {
                                var currentPrivate = (Private)soldiers.FirstOrDefault(x => x.Id == int.Parse(input[i]));
                                lieutenantGeneral.AddPrivate(currentPrivate);
                            }
                            soldiers.Add(lieutenantGeneral);
                            break;
                        case "Engineer":
                            var engineer = engineerFactory.CreateEngineer(input);
                            for (int i = 6; i < input.Length; i+=2)
                            {
                                var partName = input[i];
                                var hoursWorked = int.Parse(input[i + 1]);
                                var repair = repairFactory.CreateRepair(partName, hoursWorked);
                                engineer.AddRepair(repair);
                            }
                            soldiers.Add(engineer);
                            break;
                        case "Spy":
                            var spy = spyFactory.CreateSpy(input);
                            soldiers.Add(spy);
                            break;
                    }
                }
                catch (Exception)
                {
                    // ignored
                }
            }

            foreach (var soldier in soldiers)
            {
                Console.WriteLine(soldier.ToString());
            }
        }
    }
}
