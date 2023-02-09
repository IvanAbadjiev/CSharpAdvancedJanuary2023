using System.Collections;

int foodAlive = int.Parse(Console.ReadLine());

int[] order = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

Queue<int> queue = new Queue<int>(order);

Console.WriteLine(queue.Max());

for (int i = 0; i < order.Length; i++)
{
    if (queue.Peek() <= foodAlive)
    {
        foodAlive -= queue.Peek();
        queue.Dequeue();

    }
}

if (queue.Count > 0)
{
    Console.Write("Orders left: ");
    Console.WriteLine(string.Join(" ", queue));
}
else
{
    Console.WriteLine("Orders complete");
}