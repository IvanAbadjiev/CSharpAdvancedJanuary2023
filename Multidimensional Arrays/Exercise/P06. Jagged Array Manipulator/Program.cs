int n = int.Parse(Console.ReadLine());

int[][] jagged = new int[n][];
for (int row = 0; row < jagged.Length; row++)
    jagged[row] = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();



for (int row = 0; row < n - 1; row++)
{
    if (jagged[row].Length == jagged[row + 1].Length)
    {
        jagged[row] = jagged[row].Select(el => el * 2).ToArray();
        jagged[row + 1] = jagged[row + 1].Select(el => el * 2).ToArray();
    }
    else
    {
        jagged[row] = jagged[row].Select(el => el / 2).ToArray();
        jagged[row + 1] = jagged[row + 1].Select(el => el / 2).ToArray();
    }
}

while (true)
{
    string[] command = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .ToArray();
    string cmdType = command[0];

    if (cmdType == "End")
    {
        break;
    }
    else if (cmdType == "Add")
    {
        int row = int.Parse(command[1]);
        int column = int.Parse(command[2]);
        int value = int.Parse(command[3]);
        if (ValidateIndex(jagged, row, column))
        {
            jagged[row][column] = jagged[row][column] + value;

        }

    }
    else if (cmdType == "Subtract")
    {
        int row = int.Parse(command[1]);
        int column = int.Parse(command[2]);
        int value = int.Parse(command[3]);
        if (ValidateIndex(jagged, row, column))
        {
            jagged[row][column] = jagged[row][column] - value;

        }
    }
}

foreach (var row in jagged)
{
    Console.WriteLine(string.Join(" ", row));
}

bool ValidateIndex(int[][] jagged, int row, int column)
{
    if (row >= 0 && row < jagged.Length)
    {
        if (column >= 0 && column < jagged[row].Length)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    else
    {
        return false;
    }
}