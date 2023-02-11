//Reed Jagged array
int rows = int.Parse(Console.ReadLine());
int[][] jagged = new int[rows][];
for (int row = 0; row < jagged.Length; row++)
    jagged[row] = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();

string command = string.Empty;

while ((command = Console.ReadLine()) != "END")
{
    string cmdType = command.Split(' ')[0];
    int row = int.Parse(command.Split(" ")[1]);
    int col = int.Parse(command.Split(" ")[2]);
    int value = int.Parse(command.Split(" ")[3]);

    if (cmdType == "Add")
    {
        if (row >= 0 && row < jagged.Length && col >= 0 && col < jagged[row].Length)
        {
            jagged[row][col] += value;
        }
        else
        {
            Console.WriteLine("Invalid coordinates");
        }

    }
    else if (cmdType == "Subtract")
    {
        if (row >= 0 && row < jagged.Length && col >= 0 && col < jagged[row].Length)
        {
            jagged[row][col] -= value;
        }
        else
        {
            Console.WriteLine("Invalid coordinates");
        }
    }


}

foreach (var row in jagged)
{
    Console.WriteLine(string.Join(" ", row));
}