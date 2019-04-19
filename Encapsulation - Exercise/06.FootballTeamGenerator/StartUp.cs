namespace _06.FootballTeamGenerator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var teams = new Dictionary<string, Team>();

            while (true)
            {
                var input = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
                if (input[0] == "END")
                {
                    break;
                }

                var command = input[0];
                var teamName = input[1];
                if (command != "Team" && !teams.ContainsKey(teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist.");
                    continue;
                }
                try
                {
                    switch (command)
                    {
                        case "Team":
                            var team = new Team(teamName);
                            teams.Add(teamName, team);
                            break;
                        case "Add":
                            var playerName = input[2];
                            var endurance = int.Parse(input[3]);
                            var sprint = int.Parse(input[4]);
                            var dribble = int.Parse(input[5]);
                            var passing = int.Parse(input[6]);
                            var shooting = int.Parse(input[7]);
                            var stats = new Stat(endurance, sprint, dribble, passing, shooting);
                            var player = new Player(playerName, stats);

                            teams[teamName].AddPlayer(player);

                            break;
                        case "Remove":
                            var playerNameForRemove = input[2];
                            teams[teamName].RemovePlayer(playerNameForRemove);
                            break;
                        case "Rating":

                            var rating = teams[teamName].Players.Sum(playerInTeam => playerInTeam.AverageStat);

                            if (teams[teamName].Players.Count != 0)
                            {
                                rating = rating / (teams[teamName].Players.Count);
                            }

                            Console.WriteLine($"{teamName} - {Math.Round(rating)}");
                            break;
                    }
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }

            }
        }
    }
}
