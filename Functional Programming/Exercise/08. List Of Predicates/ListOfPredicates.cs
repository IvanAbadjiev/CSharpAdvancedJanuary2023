using System.Collections.Generic;
using System.Security.Principal;

Func<int, List<int>, List<int>> filterNumber = (endRange, numbers) =>
{
    List<int> result = new();
    for (int i = 1; i <= endRange; i++)
    {
        bool isValid = true;
        foreach (var number in numbers)
        {
            if (i % number == 0)
            {

            }
            else
            {
                isValid = false;
            }
        }
        if (isValid)
        {
            result.Add(i);
        }
    }

    return result;
};

int endRange = int.Parse(Console.ReadLine());
List<int> numbers = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();

List<int> printNumbers = filterNumber(endRange, numbers);

Console.WriteLine(string.Join(" ", printNumbers));

