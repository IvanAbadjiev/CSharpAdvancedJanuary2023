namespace P6._Supermarket
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            var people = new Queue<string>();
            while ((input = Console.ReadLine()) != "End")
            {

                if (input != "Paid")
                {
                    people.Enqueue(input);
                }
                else
                {
                    Console.WriteLine(string.Join(Environment.NewLine, people));
                    people.Clear();
                }


            }
            Console.WriteLine($"{people.Count} people remaining.");

        }
    }
}
