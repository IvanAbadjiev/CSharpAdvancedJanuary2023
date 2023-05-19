Dictionary<string, int> keyValuePairs = new Dictionary<string, int>()
            {
                {"Patch" , 30 },
                {"Bandage" , 40 },
                {"MedKit" , 100 }

            };
Dictionary<string, int> crete = new Dictionary<string, int>();

List<string> medic = new List<string>()
            {
                "Patch",
                "Bandage",
                "MedKit"

            };


int[] textiles = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray(); //textil
int[] medicaments = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

Stack<int> stackM = new Stack<int>(medicaments);// Stack FILO (first-in, last-out) -> (get last element) ;
Queue<int> queueT = new Queue<int>(textiles);// Queue FIFO (first-in, first-out); -> (get first element)


while (stackM.Count > 0 && queueT.Count > 0)
{
    int first = queueT.Peek();
    int second = stackM.Peek();

    bool isValid = false;
    foreach (var kvp in keyValuePairs)
    {
        if ((first + second) == kvp.Value)
        {
            isValid = true;
            if (!crete.ContainsKey(kvp.Key))
            {
                crete.Add(kvp.Key, 1);
            }
            else
            {
                crete[kvp.Key]++;
            }
            queueT.Dequeue();
            stackM.Pop();
            break;

        }
    }
    if (!isValid)
    {
        if ((first + second) > keyValuePairs["MedKit"])
        {

            int left = (first + second) - keyValuePairs["MedKit"];
            if (!crete.ContainsKey("MedKit"))
            {
                crete.Add("MedKit", 1);
            }
            else
            {
                crete["MedKit"]++;
            }
            stackM.Pop();
            queueT.Dequeue();

            int m = stackM.Pop();
            m += left;
            stackM.Push(m);


        }
        else
        {
            queueT.Dequeue();
            int m = stackM.Pop();
            m += 10;
            stackM.Push(m);


        }
    }


}


if (queueT.Count == 0 && stackM.Count == 0)
{

    Console.WriteLine("Textiles and medicaments are both empty.");
}
else if (queueT.Count == 0)
{
    Console.WriteLine("Textiles are empty.");
}
else if (stackM.Count == 0)
{
    Console.WriteLine("Medicaments are empty.");
}

if (crete.Any())
{

    var ordared = crete.OrderByDescending(n => n.Value).ThenBy(n => n.Key);
    foreach (var kvp in ordared)
    {
        Console.WriteLine($"{kvp.Key} - {kvp.Value}");
    }
}

if (stackM.Count > 0)
{
    Console.WriteLine($"Medicaments left: {string.Join(", ", stackM)}");
}
if (queueT.Count > 0)
{
    Console.WriteLine($"Textiles left: {string.Join(", ", queueT)}");
}
