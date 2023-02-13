int[] input = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int rowCount = input[0]; int colCount = input[1];

string[,] matrix = new string[rowCount, colCount];
BildMatrix(matrix);

while (true)
{
    string[] command = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries);

    string cmdType = command[0];
    if (cmdType == "END")
    {
        break;
    }
    else if (cmdType == "swap" && command.Length == 5)
    {
        int row = int.Parse(command[1]);
        int col = int.Parse(command[2]);

        int row1 = int.Parse(command[3]);
        int col1 = int.Parse(command[4]);

        bool isValid = ValidateIndexForOne(matrix, row, col);
        bool isValidTwo = ValidateIndexForTwo(matrix, row1, col1);
        if (isValid && isValidTwo)
        {
            SwapInMatrix(matrix, row, col, row1, col1);
            // Print matrix
            for (int roww = 0; roww < rowCount; roww++)
            {
                for (int coll = 0; coll < colCount; coll++)
                {
                    Console.Write(matrix[roww, coll] + " ");
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }
    }
    else
    {
        Console.WriteLine("Invalid input!");
    }
}

bool ValidateIndexForTwo(string[,] matrix, int row1, int col1)
{
    if (row1 >= 0 && row1 < matrix.GetLength(0))
    {
        if (col1 >= 0 && col1 < matrix.GetLength(1))
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

bool ValidateIndexForOne(string[,] matrix, int row, int col)
{
    if (row >= 0 && row < matrix.GetLength(0))
    {
        if (col >= 0 && col < matrix.GetLength(1))
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

void SwapInMatrix(string[,] matrix, int row, int col, int row1, int col1)
{
    string num1 = matrix[row, col];
    string num2 = matrix[row1, col1];

    matrix[row, col] = num2;
    matrix[row1, col1] = num1;

}

void BildMatrix(string[,] matrix)
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        string[] rowData = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .ToArray();
        for (int col = 0; col < matrix.GetLength(1); col++)
            matrix[row, col] = rowData[col];

    }



}