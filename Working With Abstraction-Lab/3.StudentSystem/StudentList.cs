namespace P03_StudentSystem
{
    using System.Collections.Generic;

    public class StudentList
    {

        public StudentList()
        {
            this.Students = new Dictionary<string, Student>();
        }

        public Dictionary<string, Student> Students { get; private set; }

        public void Create(Student student)
        {
            if (!Students.ContainsKey(student.Name))
            {
                Students[student.Name] = student;
            }
        }

        public Student StudentInfo(string studentName)
        {
            return Students.ContainsKey(studentName) ? Students[studentName] : null;
        }
    }
}
