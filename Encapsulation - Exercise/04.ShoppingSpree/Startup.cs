using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ShoppingSpree
{
    public class Startup
    {
        public static void Main()
        {
            var people = new List<Person>();
            var products = new List<Product>();

            var namesAndMoney = Console.ReadLine().Split(new[] { ";", "=" }, StringSplitOptions.RemoveEmptyEntries);
            var productsAndCost = Console.ReadLine().Split(new[] { ";", "=" }, StringSplitOptions.RemoveEmptyEntries);
            try
            {
                for (int i = 0; i < namesAndMoney.Length; i += 2)
                {
                    var name = namesAndMoney[i];
                    var money = double.Parse(namesAndMoney[i + 1]);

                    var person = new Person(name, money);
                    people.Add(person);
                }

                for (int i = 0; i < productsAndCost.Length; i += 2)
                {
                    var productName = productsAndCost[i];
                    var productCost = double.Parse(productsAndCost[i + 1]);

                    var product = new Product(productName, productCost);
                    products.Add(product);
                }
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
                return;
            }
           

            while (true)
            {
                var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (input[0] == "END")
                {
                    break;
                }
                var personName = input[0];
                var productName = input[1];

                var currentPerson = people.FirstOrDefault(x => x.Name == personName);
                var currentProduct = products.FirstOrDefault(x => x.Name == productName);
                Console.WriteLine(currentPerson.BuyProduct(currentProduct));
                
            }

            foreach (var person in people)
            {
                Console.Write($"{person.Name} - ");

                if (person.BagOfProducts.Any())
                {
                    Console.WriteLine(string.Join(", ", person.BagOfProducts.Select(x=>x.Name)));
                }
                else
                {
                    Console.WriteLine("Nothing bought");
                }
            }
        }
    }
}
