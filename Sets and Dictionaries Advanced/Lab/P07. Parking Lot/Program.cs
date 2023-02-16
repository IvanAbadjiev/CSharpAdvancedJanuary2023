string command = string.Empty;

var listCarNumber = new HashSet<string>();
while ((command = Console.ReadLine()) != "END")
{
    string[] cmdArgs = command.Split(", ", StringSplitOptions.RemoveEmptyEntries);
    string cmdType = cmdArgs[0];
    string carNumber = cmdArgs[1];

    if (cmdType == "IN")
    {
        listCarNumber.Add(carNumber);
    }
    if (cmdType == "OUT")
    {
        if (listCarNumber.Contains(carNumber))
        {
            listCarNumber.Remove(carNumber);
        }
    }
}
if (listCarNumber.Count >= 0)
{
    foreach (var carNumber in listCarNumber)
    {
        Console.WriteLine(carNumber);
    }
}
else
{
    Console.WriteLine("Parking Lot is Empty");
}
