namespace _06.BirthdayCelebrations
{
    using System;

    public class Citizen:IBirthable
    {
        private string name;

        private int age;

        public Citizen(string name,int age,string id,string birthdate)
        {
            this.name = name;
            this.age = age;
            this.BirthDate = birthdate;
        }

        public string Id { get; }
        public string BirthDate { get; }
    }
}
