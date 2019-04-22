namespace _08.MilitaryElite.Models
{
    using System.Collections.Generic;
    using Contracts;
    using System;
    using System.Text;

    public class Engineer : Private, IEngineer
    {
        private List<Repair> repairs;

        private string corps;

        public Engineer(int id, string firstName, string lastName, decimal salary, string corps)
            : base(id, firstName, lastName, salary)
        {
            this.Corps = corps;
            this.repairs = new List<Repair>();
        }

        public IList<Repair> Repairs => this.repairs.AsReadOnly();

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

        public void AddRepair(Repair repair)
        {
            this.repairs.Add(repair);
        }

        public override string ToString()
        {
            var engineerInfo = new StringBuilder();

            engineerInfo.AppendLine($"Corps: {this.corps}");
            engineerInfo.AppendLine("Repairs:");
            foreach (var repair in Repairs)
            {
                engineerInfo.AppendLine("  "+repair);
            }
            return base.ToString()+Environment.NewLine + engineerInfo.ToString().TrimEnd();
        }
    }
}
