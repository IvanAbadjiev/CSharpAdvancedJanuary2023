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
Stack<int> stack = new Stack<int>();
for (int i = 0; i < n; i++)
{
    stack.Push(InputNumberTwo[i]);
}

for (int i = 0; i < s; i++)
{
    stack.Pop();
}

if (stack.Count == 0)
{
    Console.WriteLine(0);
}
else if (stack.Contains(x))
{
    Console.WriteLine("true");
}
else
{
    Console.WriteLine(stack.Min());
}