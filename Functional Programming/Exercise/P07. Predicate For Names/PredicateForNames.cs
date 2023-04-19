Func<int, List<string>, List<string>> filterNames = (length, names) =>
{
    List<string> result = new();

    foreach (var name in names)
    {
        if (name.Length <= length)
        {
            result.Add(name);
        }

    }
    return result;

};


int length = int.Parse(Console.ReadLine());

List<string> names = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .ToList();


names = filterNames(length, names);

Console.WriteLine(string.Join(Environment.NewLine, names));