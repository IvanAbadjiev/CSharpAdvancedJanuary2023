Func<HashSet<int>, int> minNumberInSet = n =>
{
    int minNumber = int.MaxValue;

    foreach (var number in n)
    {
        if (number < minNumber)
        {
            minNumber = number;
        }
    }
    return minNumber;

};


HashSet<int> numbers = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToHashSet();

Console.WriteLine(minNumberInSet(numbers));