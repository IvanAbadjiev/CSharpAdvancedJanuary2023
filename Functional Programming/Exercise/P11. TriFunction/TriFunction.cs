using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.SymbolStore;

Func<string, int, bool> checkLength = (name, sum)
    => name.Sum(ch => ch) >= sum;


Func<List<string>, int, Func<string, int, bool>, string> firstNameToMach = (names, sum, match)
    => names.FirstOrDefault(n => checkLength(n, sum));



int sum = int.Parse(Console.ReadLine());

List<string> names = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .ToList();



Console.WriteLine(firstNameToMach(names, sum, checkLength));