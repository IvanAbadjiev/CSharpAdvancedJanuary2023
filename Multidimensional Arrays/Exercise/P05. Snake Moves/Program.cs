int[] n = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int rowCount = 0; int colCount = 0;
string inputText = Console.ReadLine();
char[,] matrix = new char[rowCount, colCount];

int index = 0;
for (int row = 0; row < rowCount; row++)
{
    if (row % 2 == 0)
    {
        for (int col = 0; col < colCount; col++)
        {
            matrix[row, col] = inputText[index];
            index++;
            if (index >= inputText.Length)
            {
                index = 0;
            }
        }
    }
    else
    {
        for (int col = colCount - 1; col >= 0; col--)
        {
            matrix[row, col] = inputText[index];
            index++;
            if (index >= inputText.Length)
            {
                index = 0;
            }
        }
    }
}

PrintMatrix(matrix);

void PrintMatrix(char[,] matrix)
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            Console.WriteLine(matrix[row, col]);
        }
        Console.WriteLine();
    }
}