using System.Collections.Generic;
using System.Security.Principal;

Func<int, List<int>, List<int>> filterNumber = (divider, numbers) =>
{
    List<int> result = new();

    foreach (var number in numbers)
    {
        if (number % divider != 0)
            result.Add(number);

    }

    return result;
};

List<int> numbers = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();

int divider = int.Parse(Console.ReadLine());

numbers = filterNumber(divider, numbers);

numbers.Reverse();

Console.WriteLine(string.Join(" ", numbers));
