namespace _09.CollectionHierarchy
{
    using System;
    using System.Collections.Generic;
    using Contracts;
    using Models;

    public class StartUp
    {
        public static void Main()
        {
            var addCollection = new AddCollection();
            var addRemoveCollection = new AddRemoveCollection();
            var myList = new MyList();

            var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var result = new List<int>();
            for (int i = 0; i < 3; i++)
            {
                foreach (var item in input)
                {
                    switch (i)
                    {
                        case 0:
                            result.Add(addCollection.AddItem(item));
                            break;
                        case 1:
                            result.Add(addRemoveCollection.AddItem(item));
                            break;
                        case 2:
                            result.Add(myList.AddItem(item));
                            break;
                    }

                    
                }
                Console.WriteLine(string.Join(" ", result));
                result.Clear();
            }

            var removeCount = int.Parse(Console.ReadLine());
            RemoveItem(removeCount,addRemoveCollection);
            RemoveItem(removeCount,myList);
        }

        private static void RemoveItem(int count, IRemoveCollection collection)
        {
            var result = new List<string>();
            for (int i = 0; i < count; i++)
            {
                result.Add(collection.Remove());
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
