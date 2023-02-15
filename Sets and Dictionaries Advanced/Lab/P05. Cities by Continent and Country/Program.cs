int n = int.Parse(Console.ReadLine());

var continentInfo = new Dictionary<string, Dictionary<string, List<string>>>();

for (int i = 0; i < n; i++)
{
    string[] curentContinentInfo = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .ToArray();

    string continent = curentContinentInfo[0];
    string country = curentContinentInfo[1];
    string city = curentContinentInfo[2];

    if (!continentInfo.ContainsKey(continent))
        continentInfo.Add(continent, new Dictionary<string, List<string>>());


    if (!continentInfo[continent].ContainsKey(country))
        continentInfo[continent].Add(country, new List<string>());

    continentInfo[continent][country].Add(city);



}

foreach (var pair in continentInfo)
{
    Console.WriteLine($"{pair.Key}:");
    foreach (var innerPair in pair.Value)
    {
        Console.WriteLine(" {0} -> {1}", innerPair.Key, string.Join(", ", innerPair.Value));
    }
}