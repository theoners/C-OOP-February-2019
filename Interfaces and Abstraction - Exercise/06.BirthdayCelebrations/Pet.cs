namespace _06.BirthdayCelebrations
{
    using System;

    public class Pet:IBirthable
    {
        private string name;

        public Pet(string name, string birthDate)
        {
            this.name = name;
            this.BirthDate = birthDate;
        }

        public string BirthDate { get; }
    }
}
