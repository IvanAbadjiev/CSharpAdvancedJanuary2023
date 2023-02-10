//reed matrix
int[] input = Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
(int rows, int cols) = (input[0], input[1]);
int[,] matrix = new int[rows, cols];
for (int row = 0; row < rows; row++)
{
    int[] curr = Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = curr[col];
    }

}

//Print matrix
//for (int row = 0; row < rows; row++)
//{
//    for (int col = 0; col < cols; col++)
//    {
//        Console.Write(matrix[row, col] + " ");
//    }
//    Console.WriteLine();
//}


long sum = 0;
for (int row = 0; row < rows; row++)
    for (int col = 0; col < cols; col++)
    {
        sum += matrix[row, col];
    }

Console.WriteLine(rows);
Console.WriteLine(cols);
Console.WriteLine(sum);


