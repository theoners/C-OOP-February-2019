namespace _07.FoodShortage
{
   public class Rebel:IBuyer
    {
        private string group;

        public Rebel(string name, int age, string group)
        {
            this.Name = name;
            this.Age = age;
            this.group = group;
            Food = 0;
        }

        public string Name { get; set; }

        public  int Age { get; }

        public int Food { get; set; }

        public void BuyFood()
        {
            Food += 5;
        }
    }
}
