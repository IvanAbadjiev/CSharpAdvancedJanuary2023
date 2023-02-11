// Read matrix
int[] input = Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
(int rowsCount, int colsCount) = (input[0], input[1]);
int[,] matrix = new int[rowsCount, colsCount];
for (int row = 0; row < rowsCount; row++)
{
    int[] curr = Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
    for (int col = 0; col < colsCount; col++)
    {
        matrix[row, col] = curr[col];
    }

}

//Sum result
long maxValue = long.MinValue;
int findRow = 0;
int findCol = 0;
for (int row = 0; row < rowsCount - 1; row++)
{
    for (int col = 0; col < colsCount - 1; col++)
    {
        long currValue = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
        if (currValue > maxValue)
        {
            maxValue = currValue;
            findRow = row;
            findCol = col;
        }
    }
}

//Console.WriteLine(matrix[result1, result2]);
//Console.WriteLine(matrix[result3, result4]);

Console.WriteLine($"{matrix[findRow, findCol]} {matrix[findRow, findCol + 1]}");
Console.WriteLine($"{matrix[findRow + 1, findCol]} {matrix[findRow + 1, findCol + 1]}");
Console.WriteLine(maxValue);

