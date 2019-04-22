namespace _07.FoodShortage
{
    public class Citizen : IBuyer
    {

        private string id;

        private string birthDate;

        public Citizen(string name, int age, string id, string birthdate)
        {
            this.Name = name;
            this.Age = age;
            this.id = id;
            this.birthDate = birthdate;
            Food = 0;
        }

        public string Name { get; set; }

        public int Age { get; }

        public int Food { get; set; }

        public void BuyFood()
        {
            Food += 10;
        }
    }
}
