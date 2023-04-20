using System.Text;

List<string> people = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .ToList();


Action<List<string>> print = listGuest =>
{
    if (listGuest.Count > 0)
    {
        Console.Write($"{string.Join(", ", listGuest)} are going to the party!");
    }
    else
    {
        Console.WriteLine("Nobody is going to the party!");
    }

};

string command = string.Empty;

while ((command = Console.ReadLine()) != "Party!")
{

    string cmdType = command.Split(" ")[0];
    string cmdArgs = command.Split(" ")[1];
    string value = command.Split(" ")[2];

    if (cmdType == "Remove")
    {
        people.RemoveAll(GetNameMatch(cmdArgs, value));
    }
    else if (cmdType == "Double")
    {

        List<string> peopleToDouble = people.FindAll(GetNameMatch(cmdArgs, value));
        foreach (var person in peopleToDouble)
        {
            int index = people.FindIndex(p => p == person);

            people.Insert(index, person);

        }


    }


}
print(people);
static Predicate<string> GetNameMatch(string cmdArgs, string value)
{

    if (cmdArgs == "StartsWith")
    {
        return p => p.StartsWith(value);
    }
    else if (cmdArgs == "EndsWith")
    {
        return p => p.EndsWith(value);

    }
    else if (cmdArgs == "Length")
    {
        return p => p.Length == int.Parse(value);

    }
    else
    {
        return default;
    }


}