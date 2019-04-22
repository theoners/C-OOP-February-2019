namespace _06.BirthdayCelebrations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var peopleAndPets = new List<IBirthable>();

            while (true)
            {
                var input = Console.ReadLine().Split();
                if (input[0]=="End")
                {
                    break;
                }

                if (input[0]=="Pet")
                {
                    var pet = new Pet(input[1],input[2]);
                    peopleAndPets.Add(pet);
                }
                else if (input[0]== "Citizen")
                {
                    var citizen = new Citizen(input[1], int.Parse(input[2]),input[3],input[4]);
                    peopleAndPets.Add(citizen);
                }
            }

            var year = Console.ReadLine();
            foreach (var personOrPet in peopleAndPets.Where(x=>x.BirthDate.EndsWith(year)))
            {
                Console.WriteLine(personOrPet.BirthDate);
            }
        }
    }
}
