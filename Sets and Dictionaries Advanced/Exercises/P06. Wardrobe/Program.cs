int n = int.Parse(Console.ReadLine());

var wardrobeInfo = new Dictionary<string, Dictionary<string, int>>();
for (int i = 0; i < n; i++)
{
    string lineData = Console.ReadLine();

    string color = lineData
        .Split(" -> ", StringSplitOptions.RemoveEmptyEntries)[0];
    string clouts = lineData
        .Split(" -> ", StringSplitOptions.RemoveEmptyEntries)[1];

    if (!wardrobeInfo.ContainsKey(color))
        wardrobeInfo.Add(color, new Dictionary<string, int>());

    string[] clout = clouts
        .Split(",", StringSplitOptions.RemoveEmptyEntries);

    foreach (var item in clout)
    {
        if (!wardrobeInfo[color].ContainsKey(item))
            wardrobeInfo[color].Add(item, 0);

        wardrobeInfo[color][item]++;
    }
}

string[] foundInfo = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .ToArray();

string foundColor = foundInfo[0];
string foundClout = foundInfo[1];


foreach (var color in wardrobeInfo)
{
    Console.WriteLine($"{color.Key} clothes:");
    foreach (var clout in wardrobeInfo[color.Key])

    {
        if (color.Key == foundColor && clout.Key == foundClout)
        {
            Console.WriteLine($"* {clout.Key} - {clout.Value} (found!)");

        }
        else
        {
            Console.WriteLine($"* {clout.Key} - {clout.Value}");

        }
    }
}