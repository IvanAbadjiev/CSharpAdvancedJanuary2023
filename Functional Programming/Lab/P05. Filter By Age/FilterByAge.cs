int n = int.Parse(Console.ReadLine());
List<Persone> listPersone = new List<Persone>();

for (int i = 0; i < n; i++)
{
    var input = Console.ReadLine()
        .Split(", ", StringSplitOptions.RemoveEmptyEntries);
    string name = input[0];
    int age = int.Parse(input[1]);

    listPersone.Add(new Persone() { name = name, age = age });
}


string filterType = Console.ReadLine();

int filterValue = int.Parse(Console.ReadLine());

Func<Persone, int, bool> filter = GetFilter(filterType);

listPersone = listPersone.Where(p => filter(p, filterValue)).ToList();

Action<Persone> formatter = Formatter(Console.ReadLine());

foreach (var item in listPersone)
{
    formatter(item);
}

Func<Persone, int, bool> GetFilter(string filterType)
{
    if (filterType == "younger")
    {
        return (p, value) => p.age < value;
    }
    else
    {
        return (Persone p, int value) => p.age >= value;
    }
}

Action<Persone> Formatter(string formatType)
{
    if (formatType == "name age")
    {
        return p => Console.WriteLine($"{p.name} - {p.age}");
    }
    if (formatType == "age")
    {
        return p => Console.WriteLine($"{p.age}");
    }
    if (formatType == "name")
    {
        return p => Console.WriteLine($"{p.name}");
    }
    return null;

}

class Persone
{
    public string name;
    public int age;
}