using System;
using System.Collections.Generic;
using System.Linq;

namespace P01BaristaContestV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> keyValuePairsCoffeeMilk = new Dictionary<string, int>()
            {
                {"Cortado" , 50 },
                {"Espresso" , 75 },
                {"Capuccino" , 100 },
                {"Americano" , 150 },
                {"Latte" , 200 }
            };
            Dictionary<string, int> creteDrink = new Dictionary<string, int>();

            List<string> drinck = new List<string>()
            {
                "Cortado",
                "Espresso",
                "Capuccino",
                "Americano",
                "Latte"
            };
            int counterDrinck = 0;
            int[] quantitiesCoffee = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();//queue
            int[] quantitiesMilk = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();//stack

            Stack<int> milk = new Stack<int>(quantitiesMilk);
            Queue<int> coffee = new Queue<int>(quantitiesCoffee);

            while (coffee.Count > 0 && milk.Count > 0)
            {
                int curentDrinckQty = coffee.Peek() + milk.Peek();
                bool isCreate = false;
                foreach (var kvp in keyValuePairsCoffeeMilk)
                {
                    if (curentDrinckQty == kvp.Value)
                    {
                        isCreate = true;
                        if (!creteDrink.ContainsKey(kvp.Key))
                        {
                            creteDrink.Add(kvp.Key, 1);

                        }
                        else
                        {
                            creteDrink[kvp.Key]++;

                        }
                        coffee.Dequeue();
                        milk.Pop();
                        break;
                    }
                }
                if (!isCreate)
                {
                    coffee.Dequeue();
                    int milkQty = milk.Pop();
                    milkQty -= 5;
                    milk.Push(milkQty);


                }







            }
            if (!coffee.Any() && !milk.Any())
            {
                Console.WriteLine("Nina is going to win! She used all the coffee and milk!");
            }
            else
            {
                Console.WriteLine("Nina needs to exercise more! She didn't use all the coffee and milk!");
            }


            if (coffee.Any())
            {
                Console.WriteLine($"Coffee left: {string.Join(", ", coffee)}");
            }
            else
            {
                Console.WriteLine("Coffee left: none");
            }

            if (milk.Any())
            {
                Console.WriteLine($"Milk left: {string.Join(", ", milk)}");
            }
            else
            {
                Console.WriteLine("Milk left: none");
            }

            var ordaredDrink = creteDrink.OrderBy(n => n.Value).ThenByDescending(n => n.Key);
            foreach (var kvp in ordaredDrink)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }





        }

    }
}