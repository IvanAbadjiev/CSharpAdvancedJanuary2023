using System;
using System.Collections.Generic;
using System.Linq;

namespace P01TilesMaster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> databasse = new Dictionary<string, int>()
{
    {  "Sink" , 40 },
    {  "Oven" , 50 },
    {  "Countertop" , 60 },
    {  "Wall" , 70 }


};
            Dictionary<string, int> crete = new Dictionary<string, int>();

            int[] whiteTiles = Console.ReadLine()
     .Split(" ", StringSplitOptions.RemoveEmptyEntries)
     .Select(int.Parse)
     .ToArray(); //stack get last
            int[] greyTiles = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray(); // queue get first

            Stack<int> white = new Stack<int>(whiteTiles);
            Queue<int> grey = new Queue<int>(greyTiles);

            string[] wear =
{
    "Sink",
    "Oven",
   "Countertop",
    "Wall"



};
            while (white.Count > 0 && grey.Count > 0)
            {
                int firstTiles = white.Peek();
                int secondTiles = grey.Peek();
                if (firstTiles == secondTiles)
                {
                    int tiles = firstTiles + secondTiles;
                    bool isValid = false;

                    foreach (var item in wear)
                    {
                        if (databasse[item] == tiles)
                        {

                            white.Pop();
                            grey.Dequeue();
                            isValid = true;
                            if (!crete.ContainsKey(item))
                            {
                                crete.Add(item, 1);
                            }
                            else
                            {
                                crete[item]++;
                            }
                            break;
                        }


                    }




                    if (!isValid)
                    {
                        white.Pop();
                        grey.Dequeue();
                        if (!crete.ContainsKey("Floor"))
                        {
                            crete.Add("Floor", 1);
                        }
                        else
                        {
                            crete["Floor"]++;
                        }
                    }


                }
                else
                {
                    int w = white.Pop();
                    w -= w / 2;
                    white.Push(w);
                    //Stack<int> stackCopy = new Stack<int>();
                    //stackCopy.Push(w);
                    //while (white.Count > 0)
                    //{
                    //    int first = white.Pop();
                    //    stackCopy.Push(first);
                    //}
                    //white = stackCopy;
                    //white.(w);

                    int g = grey.Dequeue();
                    grey.Enqueue(g);
                }


            }

            if (white.Any())
            {
                Console.WriteLine($"White tiles left: {string.Join(", ", white)}");
            }
            else
            {
                Console.WriteLine("White tiles left: none");
            }

            if (grey.Any())
            {
                Console.WriteLine($"Grey tiles left: {string.Join(", ", grey)}");
            }
            else
            {
                Console.WriteLine("Grey tiles left: none");
            }

            var ordaredDrink = crete.OrderByDescending(n => n.Value).ThenBy(n => n.Key);
            foreach (var kvp in ordaredDrink)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }


        }
    }
}
