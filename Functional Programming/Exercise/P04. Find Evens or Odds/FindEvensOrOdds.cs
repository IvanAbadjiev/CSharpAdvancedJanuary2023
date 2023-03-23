Func<int, int, List<int>> genereteRange = (start, end) =>
{
    List<int> range = new();
    for (int i = start; i <= end; i++)
    {
        range.Add(i);
    }

    return range;

};

Predicate<int> match;
int[] range = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

List<int> numbers = genereteRange(range[0], range[1]);
string command = Console.ReadLine();
if (command == "even")
{
    match = number => number % 2 == 0;

}
else if (command == "odd")
{
    match = number => number % 2 != 0;

}
else
{
    match = number => false;
}

foreach (int number in numbers)
{
    if (match(number))
    {
        Console.Write($"{number} ");


    }
}