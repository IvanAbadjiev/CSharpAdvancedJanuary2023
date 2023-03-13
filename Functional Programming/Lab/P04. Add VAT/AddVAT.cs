Func<double, double> addVAT = n => (n + (n / 100) * 20);

var nums = Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(double.Parse)
    .Select(addVAT)
    .ToArray();

foreach (var num in nums)
{
    Console.WriteLine($"{num:f2}");
}
