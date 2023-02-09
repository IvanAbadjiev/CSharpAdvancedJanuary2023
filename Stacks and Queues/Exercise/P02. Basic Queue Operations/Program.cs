int[] inputNumber = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int n = inputNumber[0];
int s = inputNumber[1];
int x = inputNumber[2];

int[] InputNumberTwo = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
Queue<int> queue = new Queue<int>();
for (int i = 0; i < n; i++)
{
    queue.Enqueue(InputNumberTwo[i]);
}

for (int i = 0; i < s; i++)
{
    queue.Dequeue();
}

if (queue.Count == 0)
{
    Console.WriteLine(0);
}
else if (queue.Contains(x))
{
    Console.WriteLine("true");
}
else
{
    Console.WriteLine(queue.Min());
}