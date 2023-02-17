int[] inputInfo = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int n = inputInfo[0];
int m = inputInfo[1];

var numberN = new HashSet<int>();
var numberM = new HashSet<int>();
for (int i = 0; i < n; i++)
{
    int currNumber = int.Parse(Console.ReadLine());
    numberN.Add(currNumber);
}

for (int i = 0; i < m; i++)
{
    int currNumber = int.Parse(Console.ReadLine());
    numberM.Add(currNumber);
}

numberN.IntersectWith(numberM);

Console.WriteLine(string.Join(" ", numberN));