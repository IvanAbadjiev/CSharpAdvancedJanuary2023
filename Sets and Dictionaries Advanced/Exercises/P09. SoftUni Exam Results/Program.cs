string command = string.Empty;

var database = new Dictionary<string, int>();
var sumbmitInfo = new Dictionary<string, int>();

//List<string> banned = new List<string>();
while ((command = Console.ReadLine()) != "exam finished")
{
    string[] cmdArgs = command
        .Split("-", StringSplitOptions.RemoveEmptyEntries)
        .ToArray();

    string name = cmdArgs[0];
    string type = cmdArgs[1];

    if (type != "banned")
    {
        int point = int.Parse(cmdArgs[2]);
        if (!database.ContainsKey(name))
        {
            database.Add(name, 0);
            database[name] = (point);
        }
        else
        {
            int lastPoint = database[name];
            if (point > lastPoint)
            {
                database[name] = point;
            }



        }



        if (!sumbmitInfo.ContainsKey(type))
            sumbmitInfo.Add(type, 0);

        sumbmitInfo[type]++;
    }
    else
    {
        database.Remove(name);



    }


}
var sortedTest2 = database.OrderByDescending(entry => entry.Value).ThenBy(entry => entry.Key);
var sortedTest = sumbmitInfo.OrderByDescending(entry => entry.Value).ThenBy(entry => entry.Key);
Console.WriteLine("Results:");
foreach (var name in sortedTest2)
{

    Console.WriteLine($"{name.Key} | {name.Value}");

}

Console.WriteLine("Submissions: ");
foreach (var type in sortedTest)
{
    Console.WriteLine($"{type.Key} - {type.Value}");
}