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
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
    for (int col = 0; col < colsCount; col++)
    {
        matrix[row, col] = curr[col];
    }

}

//Sum result
int[] result = new int[colsCount];
for (int row = 0; row < rowsCount; row++)
{
    for (int col = 0; col < colsCount; col++)
    {
        result[col] += matrix[row, col];
    }
}

//print result
for (int col = 0; col < colsCount; col++)
    Console.WriteLine(result[col]);
