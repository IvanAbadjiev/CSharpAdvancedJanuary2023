Action<string[]> printNames = n => Console.WriteLine(string.Join(Environment.NewLine, n));

string[] names = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .ToArray();

printNames(names);