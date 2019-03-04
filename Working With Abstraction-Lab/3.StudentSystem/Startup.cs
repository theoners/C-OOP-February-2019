namespace P03_StudentSystem
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var studentsInfo = new StudentList();
            while (true)
            {
                var args = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (args[0]=="Exit")
                {
                    break;
                }

                var name = args[1];

                switch (args[0])
                {
                    case "Create":
                    {
                        var age = int.Parse(args[2]);
                        var grade = double.Parse(args[3]);
                        var student = new Student(name,age,grade);
                        studentsInfo.Create(student);
                        break;
                    }
                    case "Show":
                    {
                        var student = studentsInfo.StudentInfo(name);

                        if (student!=null)
                        {
                            Console.WriteLine(student);
                        }

                        break;
                    }
                }
            }
        }
    }
}
