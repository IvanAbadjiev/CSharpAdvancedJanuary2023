//Read Matrix
int rowsCount = int.Parse(Console.ReadLine());
int colsCount = rowsCount;
int[,] matrix = new int[rowsCount, colsCount];
for (int row = 0; row < rowsCount; row++)
{
    string line = Console.ReadLine();
    for (int col = 0; col < colsCount; col++)
    {
        matrix[row, col] = line[col];
    }
}
//Get Symbol
char symbol = char.Parse(Console.ReadLine());
int asciiCodeSymbol = (int)symbol;


//Print result found it
bool isFound = false;
for (int row = 0; row < rowsCount; row++)
{
    for (int col = 0; col < colsCount; col++)
    {
        if (asciiCodeSymbol == matrix[row, col])
        {
            Console.WriteLine($"({row}, {col})");
            isFound = true;
            break;
        }
        if (isFound)
        {
            break;
        }
    }

}
//Print result not found it
if (!isFound)
{
    Console.WriteLine($"{symbol} does not occur in the matrix");
}