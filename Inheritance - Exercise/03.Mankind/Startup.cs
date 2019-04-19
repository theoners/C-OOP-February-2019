namespace _03.Mankind
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var studentInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);


            var studentFirstName = studentInfo[0];
            var studentLastName = studentInfo[1];
            var studentFacultyNumber = studentInfo[2];

            var workerInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var workerFirstName = workerInfo[0];
            var workerLastName = workerInfo[1];
            var workerWeekSalary = decimal.Parse(workerInfo[2]);
            var workerWorkHoursPerDay = decimal.Parse(workerInfo[3]);
            try
            {
                var student = new Student(studentFirstName, studentLastName, studentFacultyNumber);
                var worker = new Worker(workerFirstName, workerLastName, workerWeekSalary, workerWorkHoursPerDay);

                Console.WriteLine(student);
                Console.WriteLine();
                Console.WriteLine(worker);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
            
        }
    }
}
