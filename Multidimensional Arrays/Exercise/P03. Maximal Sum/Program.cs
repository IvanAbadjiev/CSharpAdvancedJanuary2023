int[] input = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int rowCount = input[0];
int colCount = input[1];

int[,] matrix = new int[rowCount, colCount];
BildMatrix(matrix);

int maxSum = int.MinValue;
int rowForPrint = 0;
int colForPrint = 0;

for (int row = 0; row < rowCount - 2; row++)
{
    for (int col = 0; col < colCount - 2; col++)
    {
        int currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                  matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                  matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
        if (currentSum > maxSum)
        {
            maxSum = currentSum;
            rowForPrint = row;
            colForPrint = col;
        }
    }
}
Console.WriteLine("Sum " + "= " + maxSum);
Console.WriteLine($"{matrix[rowForPrint, colForPrint]} {matrix[rowForPrint, colForPrint + 1]} {matrix[rowForPrint, colForPrint + 2]}{Environment.NewLine}" +
    $"{matrix[rowForPrint + 1, colForPrint]} {matrix[rowForPrint + 1, colForPrint + 1]} {matrix[rowForPrint + 1, colForPrint + 2]}{Environment.NewLine}" +
    $"{matrix[rowForPrint + 2, colForPrint]} {matrix[rowForPrint + 2, colForPrint + 1]} {matrix[rowForPrint + 2, colForPrint + 2]}");



void BildMatrix(int[,] matrix)
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        int[] rowData = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
        for (int col = 0; col < matrix.GetLength(1); col++)
            matrix[row, col] = rowData[col];

    }



}
