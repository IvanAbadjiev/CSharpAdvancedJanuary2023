int[] input = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int rowCount = input[0];
int colCount = input[1];

char[,] matrix = new char[rowCount, colCount];
BildMatrix(matrix);

int squaresInMatrixCounter = 0;
for (int row = 0; row < rowCount - 1; row++)
{
    for (int col = 0; col < colCount - 1; col++)
    {
        if (matrix[row, col] == matrix[row, col + 1]
            && matrix[row, col] == matrix[row + 1, col]
            && matrix[row, col] == matrix[row + 1, col + 1])
        {
            squaresInMatrixCounter++;
        }
    }
}

Console.WriteLine(squaresInMatrixCounter);



void BildMatrix(char[,] matrix)
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        char[] rowData = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(char.Parse)
            .ToArray();
        for (int col = 0; col < matrix.GetLength(1); col++)
            matrix[row, col] = rowData[col];

    }



}