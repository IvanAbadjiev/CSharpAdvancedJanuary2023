int n = int.Parse(Console.ReadLine());



Stack<int> stack = new Stack<int>();

for (int i = 0; i < n; i++)
{
    int[] command = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
   
    if (command[0] == 1)
    {
        int elementX = command[1];
        stack.Push(elementX);
    }
    else if (command[0] == 2)
    {
        stack.Pop();
    }
    else if (command[0] == 3)
    {
        if (stack.Count > 0)
        {
        Console.WriteLine(stack.Max());

        }
    }
    else if (command[0] == 4)
    {
        if (stack.Count > 0)
        {
        Console.WriteLine(stack.Min());

        }
    }

}
Console.WriteLine(string.Join(", ", stack));