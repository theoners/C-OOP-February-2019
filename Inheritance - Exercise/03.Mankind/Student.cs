namespace _03.Mankind
{
    using System;
    using System.Text;
    using System.Linq;

    public class Student:Human
    {
        private string facultyNumber;

        public string FacultyNumber
        {
            get => facultyNumber;
            set
            {
                if (value.Length<5 || value.Length>10 || CheckFacultyNumber(value))
                {
                    throw new ArgumentException("Invalid faculty number!");
                }
                this.facultyNumber = value;
            }
        }

        public Student(string firstName, string lastName,string facultyNumber) : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public override string ToString()
        {
            var studentInfo = new StringBuilder();
            studentInfo.AppendLine($"First Name: {this.FirstName}");
            studentInfo.AppendLine($"Last Name: {this.LastName}");
            studentInfo.Append($"Faculty number: {this.FacultyNumber}");

            return studentInfo.ToString();
        }

        public bool CheckFacultyNumber(string facultyNumber)
        {
            var symbol = facultyNumber.FirstOrDefault(x => !char.IsLetterOrDigit(x));

            return symbol != '\0';
        }
    }
}
