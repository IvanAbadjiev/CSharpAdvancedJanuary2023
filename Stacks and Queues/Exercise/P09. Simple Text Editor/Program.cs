using System.Text;

int n = int.Parse(Console.ReadLine());

StringBuilder sb = new StringBuilder();

Stack<string> textHistori = new Stack<string>();
for (int i = 0; i < n; i++)
{
    string[] command = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .ToArray();

    int cmdType = int.Parse(command[0]);

    if (cmdType == 1)
    {
        textHistori.Push(sb.ToString());

        string newTextAdd = command[1];
        sb.Append(newTextAdd);
    }
    else if (cmdType == 2)
    {
        textHistori.Push(sb.ToString());

        int count = int.Parse(command[1]);
        sb.Remove(sb.Length - count, count);

    }
    else if (cmdType == 3)
    {
        int index = int.Parse(command[1]);
        Console.WriteLine(sb[index - 1]);
    }
    else if (cmdType == 4)
    {
        sb.Clear();
        sb.Append(textHistori.Pop());
    }

}