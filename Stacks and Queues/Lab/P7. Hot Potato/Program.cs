namespace P7._Hot_Potato
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        static void Main(string[] args)
        {
            string[] childs = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int n = int.Parse(Console.ReadLine());
            var queue = new Queue<string>(childs);

            while (queue.Count > 1)
            {
                for (int i = 1; i <= n - 1; i++)
                {
                    var child = queue.Dequeue();
                    queue.Enqueue(child);
                }
                var lostChild = queue.Dequeue();
                Console.WriteLine($"Removed {lostChild}");
            }
            var lastChild = queue.Dequeue();
            Console.WriteLine($"Last is {lastChild}");





        }
    }
}
