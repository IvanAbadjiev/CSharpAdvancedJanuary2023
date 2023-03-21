Action<string[], string> printNames = (n, t) =>
{
    foreach (var name in n)
    {
        Console.WriteLine($"{t} {name}");
    }
};

string[] names = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .ToArray();

const string title = "Sir";
printNames(names, title);