string[] songInput = Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .ToArray();

Queue<string> queue = new Queue<string>(songInput);

while (queue.Count > 0)
{
    string command = Console.ReadLine();

    if (command == "Play")
    {
        queue.Dequeue();

    }
    else if (command.Contains("Add"))
    {
        string songName = command.Substring(4);
        if (queue.Contains(songName))
        {
            Console.WriteLine($"{songName} is already contained!");
        }
        else
        {
            queue.Enqueue(songName);
        }

    }
    else if (command == "Show")
    {
        Console.WriteLine(string.Join(", ", queue));
    }
}

Console.WriteLine("No more songs!");