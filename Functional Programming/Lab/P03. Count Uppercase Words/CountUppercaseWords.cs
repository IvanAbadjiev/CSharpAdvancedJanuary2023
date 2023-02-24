var nums = Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int sum = nums.Sum();

Console.WriteLine(nums.Length);
Console.WriteLine(sum);