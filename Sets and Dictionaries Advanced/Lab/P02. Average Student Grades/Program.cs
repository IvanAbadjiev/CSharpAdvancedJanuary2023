int n = int.Parse(Console.ReadLine());

var students = new Dictionary<string, List<decimal>>();
for (int i = 0; i < n; i++)
{
    string[] inputData = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries);

    string name = inputData[0];
    decimal grade = decimal.Parse(inputData[1]);

    if (!students.ContainsKey(name))
        students.Add(name, new List<decimal>());
    students[name].Add(grade);

}

//foreach (KeyValuePair<string, List<decimal>> entry in students)
//{
//    Console.WriteLine($"{entry.Key} -> {string.Join(" ", entry.Value):f2} (avg: {entry.Value.Average():f2})");
//}
foreach (var item in students)
{
    Console.Write($"{item.Key} -> ");
    foreach (var grade in item.Value)
    {
        Console.Write($"{grade:f2} ");
    }
    Console.Write($"(avg: {item.Value.Average():f2})");
    Console.WriteLine();
}