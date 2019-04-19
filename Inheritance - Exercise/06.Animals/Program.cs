using System.Linq;
using _06.Animals.Animals.Cats;

namespace _06.Animals
{
    using System.Collections.Generic;
    using Animals;
    using System;

    public class Program
    {
       public static void Main()
       {
            while (true)
            {
                var animalType = Console.ReadLine();
                var animals = new Stack<Animal>();
                if (animalType== "Beast!")
                {
                    break;
                }

                try
                {
                    var animalArgs = Console.ReadLine().Split(" ");
                    var name = animalArgs[0];
                    var age = int.Parse(animalArgs[1]);
                    var gender = animalArgs[2];
                    switch (animalType)
                    {
                        case "Dog":
                            var dog = new Dog(name, age, gender);
                            animals.Push(dog);
                            break;
                        case "Cat":
                            var cat = new Cat(name, age, gender);
                            animals.Push(cat);
                            break;
                        case "Frog":
                            var frog = new Frog(name, age, gender);
                            animals.Push(frog);
                            break;
                        case "Kitten":
                            var kitten = new Kitten(name, age);
                            animals.Push(kitten);
                            break;
                        case "Tomcat":
                            var tomcat = new Tomcat(name, age);
                            animals.Push(tomcat);
                            break;
                        default:
                            throw new InvalidInputException();
                    }

                    if (animals.Any())
                    {
                        Console.WriteLine(animals.Pop().ToString());
                    }
                    
                }
                catch (InvalidInputException exception)
                {
                    Console.WriteLine(exception.Message);
                }
                
            }
        }
    }
}
