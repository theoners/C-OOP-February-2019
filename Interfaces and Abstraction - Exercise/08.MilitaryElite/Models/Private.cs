using System.Text;

namespace _08.MilitaryElite.Models
{
    using System;
    using Contracts;

    public class Private :Soldier, IPrivate
    {
        private decimal salary;

        public Private(int id, string firstName, string lastName, decimal salary)
            :base(id,firstName,lastName)
        {
            this.Salary = salary;
        }

        public decimal Salary
        {
            get => this.salary;

            private set
            {
                if (value < 0)
                {
                    throw new Exception("Invalid input");
                }

                this.salary = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + $"Salary: {this.salary:F2}";
        }
    }
}
