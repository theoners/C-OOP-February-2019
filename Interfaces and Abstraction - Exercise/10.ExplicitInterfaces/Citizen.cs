namespace _10.ExplicitInterfaces
{
    using Contracts;

    public class Citizen : IResident, IPerson
    {
        public Citizen(string name, string country, int age)
        {
            this.Name = name;
            this.Country = country;
            this.Age = age;
        }

        public string Name { get; }
        public int Age { get; }
        public string Country { get; }

        string IPerson.GetName()
        {
            return this.Name;
        }
        string IResident.GetName()
        {
            return $"Mr/Ms/Mrs {this.Name}";
        }


    }
}
