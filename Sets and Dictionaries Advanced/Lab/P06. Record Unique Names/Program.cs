int n = int.Parse(Console.ReadLine());
HashSet<string> listOfNames = new HashSet<string>();

for (int i = 0; i < n; i++)
{
    string currName = Console.ReadLine();
    listOfNames.Add(currName);
}

foreach (var name in listOfNames)
{
    Console.WriteLine(name);
}
