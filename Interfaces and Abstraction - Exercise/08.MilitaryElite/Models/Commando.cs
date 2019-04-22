namespace _08.MilitaryElite.Models
{
    using System.Linq;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Commando:Private
    {
        private string corps;
        private List<Mission> missions;
        public Commando(int id, string firstName, string lastName, decimal salary, string corps) 
            : base(id, firstName, lastName, salary)
        {
            this.missions=new List<Mission>();
            this.Corps = corps;
        }

        public IList<Mission> Missions => this.missions.AsReadOnly();

        public string Corps
        {
            get => this.corps;

            private set
            {
                if (value != "Airforces" && value != "Marines")
                {
                    throw new Exception("Invalid input");
                }
                this.corps = value;
            }
        }

        public void AddMission(Mission mission)
        {
            if (missions.Any(x=>x.CodeName==mission.CodeName))
            {
                var index = missions.FindIndex(x => x.CodeName == mission.CodeName);
                missions[index].CompleteMission();

            }
            else
            {
                if (mission.State!=null)
                {
                    this.missions.Add(mission);
                }
                
            }
           
        }

        public override string ToString()
        {
            var commandoInfo = new StringBuilder();
            commandoInfo.AppendLine($"Corps: {this.corps}");
            commandoInfo.AppendLine("Missions:");
            foreach (var mission in Missions)
            {
                commandoInfo.AppendLine(" "+mission);
            }

            return base.ToString()+Environment.NewLine+commandoInfo.ToString().TrimEnd();
        }
    }
}
