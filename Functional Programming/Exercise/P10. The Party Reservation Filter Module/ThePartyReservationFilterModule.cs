using System.Text;

List<string> people = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .ToList();


Action<List<string>> print = listGuest =>
{
    Console.Write(string.Join(" ", listGuest));
};

string command = string.Empty;

Dictionary<string, Predicate<string>> keyValuePairs = new Dictionary<string, Predicate<string>>();
while ((command = Console.ReadLine()) != "Print")
{

    string cmdType = command.Split(";")[0];
    string cmdArgs = command.Split(";")[1];
    string value = command.Split(";")[2];

    if (cmdType == "Add filter")
    {
        keyValuePairs.Add(cmdArgs + value, GetNameMatch(cmdArgs, value));
    }
    else if (cmdType == "Remove filter")
    {
        keyValuePairs.Remove(cmdArgs + value);
    }


}

foreach (var filter in keyValuePairs)
{
    people.RemoveAll(filter.Value);
}

print(people);
static Predicate<string> GetNameMatch(string cmdArgs, string value)
{

    if (cmdArgs == "Starts with")
    {
        return p => p.StartsWith(value);
    }
    else if (cmdArgs == "Ends with")
    {
        return p => p.EndsWith(value);

    }
    else if (cmdArgs == "Contains")
    {
        return p => p.Contains(value);
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