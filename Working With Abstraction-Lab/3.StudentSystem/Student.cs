namespace P03_StudentSystem
{
    public class Student
    {
        public Student(string name, int age, double grade)
        {
            this.Name = name;
            this.Age = age;
            this.Grade = grade;
        }

        public double Grade { get;}

        public int Age { get;}

        public string Name { get;}

        public override string ToString()
        {
            var info = $"{this.Name} is {this.Age} years old.";

            if (this.Grade >= 5.00)
            {
                info += " Excellent student.";
            }
            else if (this.Grade < 5.00 && this.Grade >= 3.50)
            {
                info += " Average student.";
            }
            else
            {
                info += " Very nice person.";
            }

            return info;
        }
    }
}