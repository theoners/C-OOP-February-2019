namespace _06.Animals.Animals
{
    using System.Text;
    using Contracts;

    public abstract class Animal : ISoundProducable
    {
        private string name;
        private int age;
        private string gender;

        protected Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name
        {
            get => this.name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new InvalidInputException();
                }
                this.name = value;
            }
        }

        public int Age
        {
            get => age;
            set
            {
                if (value < 0)
                {
                    throw new InvalidInputException();
                }
                this.age = value;
            }

        }

        public string Gender
        {
            get => gender;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new InvalidInputException();
                }

                this.gender = value;
            }
        }

        public virtual string ProduceSound()
        {
            return string.Empty;
        }

        public override string ToString()
        {
            var animalInfo = new StringBuilder();
            animalInfo.AppendLine($"{this.GetType().Name}")
                      .AppendLine($"{this.Name} {this.Age} {this.Gender}")
                      .AppendLine($"{this.ProduceSound()}");

            return animalInfo.ToString().TrimEnd();
        }
    }
}
