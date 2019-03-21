namespace _03.WildFarm
{
    using System;
    using System.Collections.Generic;
    using Factory;
    using Models.Animals;

    public class StartUp
    {
        public static void Main()
        {
            var animals = new List<Animal>();
            while (true)
            {
                var animalInfo = Console.ReadLine().Split();

                
                if (animalInfo[0]=="End")
                {
                    break;
                }
                var animal = AnimalFactory.CreateAnimal(animalInfo);

                var food = FoodFactory.GetFood(Console.ReadLine().Split());

                Console.WriteLine(animal.Sound());
                
                try
                {
                    animal.Eat(food);
                    
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }

                animals.Add(animal);
                
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
    }
}
