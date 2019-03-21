namespace _03.WildFarm.Factory
{
    using System;
    using Models.Animals;

    public abstract class AnimalFactory
    {
        public static Animal CreateAnimal(string[] input)
        {
            var type = input[0].ToLower();
            var name = input[1];
            var weight = double.Parse(input[2]);
            switch (type)
            {
                case "owl":
                    return new Owl(name, weight, double.Parse(input[3]));

                case "hen":
                    return new Hen(name, weight, double.Parse(input[3]));

                case "cat":
                    return new Cat(name, weight, input[3], input[4]);

                case "tiger":
                    return new Tiger(name, weight, input[3], input[4]);

                case "dog":
                    return new Dog(name, weight, input[3]);

                case "mouse":
                    return new Mouse(name, weight, input[3]);

                default:
                    throw new ArgumentException($"{type} is not a valid Animal type.");
            }
        }
    }
}
