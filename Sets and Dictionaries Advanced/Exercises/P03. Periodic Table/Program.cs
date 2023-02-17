int n = int.Parse(Console.ReadLine());

var element = new SortedSet<string>();
for (int i = 0; i < n; i++)
{
    string[] line = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .ToArray();

    for (int m = 0; m < line.Length; m++)
    {
        element.Add(line[m]);
    }

}

Console.WriteLine(string.Join(" ", element));