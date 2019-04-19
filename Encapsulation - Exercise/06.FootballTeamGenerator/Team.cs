namespace _06.FootballTeamGenerator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Team
    {
        private string name;
        private List<Player> players;
        

        public Team(string name)
        {
            this.Name = name;
            this.players = new List<Player>();
        }

        public IList<Player> Players => this.players.AsReadOnly();

        public string Name
        {
            get => this.name;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }

                this.name = value;
            }
        }

        public void AddPlayer(Player player)
        {
            if (player != null)
            {
                players.Add(player);
            }

        }

        public void RemovePlayer(string playerName)
        {
            if (players.All(x => x.Name != playerName))
            {
                throw new ArgumentException($"Player {playerName} is not in {this.name} team.");
            }
            players.RemoveAll(x => x.Name == playerName);
        }
    }
}
