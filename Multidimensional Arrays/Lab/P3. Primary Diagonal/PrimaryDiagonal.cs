//read matrix
int rowsCount = int.Parse(Console.ReadLine());
int colsCount = rowsCount;
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

//Sum matrix diagonale

int[] result = new int[rowsCount];

for (int row = 0; row < rowsCount; row++)
    for (int col = 0; col <= row; col++)
    {
        result[row] = matrix[row, col];
    }


Console.WriteLine(result.Sum());
