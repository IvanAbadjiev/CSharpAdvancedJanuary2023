int n = int.Parse(Console.ReadLine());

var nameList = new HashSet<string>();

for (int i = 0; i < n; i++)
{
    string currName = Console.ReadLine();
    nameList.Add(currName);
}

Console.WriteLine(string.Join(Environment.NewLine, nameList));