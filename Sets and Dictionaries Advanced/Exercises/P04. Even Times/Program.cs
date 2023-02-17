int n = int.Parse(Console.ReadLine());

var numberInfo = new Dictionary<int, int>();
for (int i = 0; i < n; i++)
{
    int currNumber = int.Parse(Console.ReadLine());

    if (!numberInfo.ContainsKey(currNumber))
        numberInfo.Add(currNumber, 0);

    numberInfo[currNumber]++;
}

foreach (var number in numberInfo)
{
    if (number.Value % 2 == 0)
    {
        Console.WriteLine(number.Key);
    }

}