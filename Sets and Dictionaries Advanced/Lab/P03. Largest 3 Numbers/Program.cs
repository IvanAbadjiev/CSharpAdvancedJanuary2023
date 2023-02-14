int[] inputNumber = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .OrderByDescending(n => n)
    .Take(3)
    .ToArray();


Console.WriteLine(string.Join(" ", inputNumber));



