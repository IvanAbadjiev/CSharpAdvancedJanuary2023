namespace P5._Print_Even_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();


            Queue<int> ints = new Queue<int>();

            foreach (int num in input)
            {
                if (num % 2 == 0)
                {
                    ints.Enqueue(num);
                }
            }

            Console.WriteLine(string.Join(", ", ints));
        }
    }
}
