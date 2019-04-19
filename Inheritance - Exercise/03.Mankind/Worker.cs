namespace _03.Mankind
{
    using System.Text;

    using System;

    public class Worker:Human
    {
        private const decimal weekDays = 5;
        private decimal weekSalary;
        private decimal workHoursPerDay;

        public decimal WeekSalary
        {
            get=>this.weekSalary;
            set
            {
                if (value<10)
                {
                    throw new ArgumentException($"Expected value mismatch! Argument: weekSalary");
                }
                this.weekSalary = value;
            }
        }

        public decimal WorkHoursPerDay
        {
            get => this.workHoursPerDay;
            set
            {
                if (value<1 || value>12)
                {
                    throw new ArgumentException($"Expected value mismatch! Argument: workHoursPerDay");
                }
                this.workHoursPerDay = value;
            }
        }

        public decimal CalculateSalaryPerHour()
        {
            var salaryPerHour = this.WeekSalary / (this.WorkHoursPerDay*weekDays);

            return salaryPerHour;
        }

        public Worker(string firstName, string lastName, decimal weekSalary, decimal workHoursPerDay) : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public override string ToString()
        {
            var workerInfo = new StringBuilder();
            workerInfo.AppendLine($"First Name: {this.FirstName}");
            workerInfo.AppendLine($"Last Name: {this.LastName}");
            workerInfo.AppendLine($"Week Salary: {weekSalary:F2}");
            workerInfo.AppendLine($"Hours per day: {this.WorkHoursPerDay:F2}");
            workerInfo.Append($"Salary per hour: {this.CalculateSalaryPerHour():F2}");

            return workerInfo.ToString();
        }
    }
}
