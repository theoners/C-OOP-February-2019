

namespace P05_GreedyTimes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class GreedyTimes
    {
        public static void Main()
        {
            var bagCapacity = long.Parse(Console.ReadLine());
            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var bag = new Dictionary<string, Dictionary<string, long>>();
            var gold = 0L;
            var gems = 0L;
            var cash = 0L;

            for (int i = 0; i < input.Length; i += 2)
            {
                var name = input[i];
                var value = long.Parse(input[i + 1]);

                var item = string.Empty;

                if (name.Length == 3)
                {
                    item = "Cash";
                }
                else if (name.ToLower().EndsWith("gem"))
                {
                    item = "Gem";
                }
                else if (name.ToLower() == "gold")
                {
                    item = "Gold";
                }

                if (item == "")
                {
                    continue;
                }
                else if (bagCapacity < bag.Values.Select(x => x.Values.Sum()).Sum() + value)
                {
                    continue;
                }

                switch (item)
                {
                    case "Gem":
                        if (!bag.ContainsKey(item))
                        {
                            if (bag.ContainsKey("Gold"))
                            {
                                if (value > bag["Gold"].Values.Sum())
                                {
                                    continue;
                                }
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else if (bag[item].Values.Sum() + value > bag["Gold"].Values.Sum())
                        {
                            continue;
                        }
                        break;
                    case "Cash":
                        if (!bag.ContainsKey(item))
                        {
                            if (bag.ContainsKey("Gem"))
                            {
                                if (value > bag["Gem"].Values.Sum())
                                {
                                    continue;
                                }
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else if (bag[item].Values.Sum() + value > bag["Gem"].Values.Sum())
                        {
                            continue;
                        }
                        break;
                }

                if (!bag.ContainsKey(item))
                {
                    bag[item] = new Dictionary<string, long>();
                }

                if (!bag[item].ContainsKey(name))
                {
                    bag[item][name] = 0;
                }

                bag[item][name] += value;
                if (item == "Gold")
                {
                    gold += value;
                }
                else if (item == "Gem")
                {
                    gems += value;
                }
                else if (item == "Cash")
                {
                    cash += value;
                }
            }

            foreach (var x in bag)
            {
                Console.WriteLine($"<{x.Key}> ${x.Value.Values.Sum()}");
                foreach (var item2 in x.Value.OrderByDescending(y => y.Key).ThenBy(y => y.Value))
                {
                    Console.WriteLine($"##{item2.Key} - {item2.Value}");
                }
            }
        }
    }
}