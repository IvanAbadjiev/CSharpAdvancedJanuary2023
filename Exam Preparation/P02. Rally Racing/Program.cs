int sizeSquareMatrix = int.Parse(Console.ReadLine());
int racingNumber = int.Parse(Console.ReadLine());
int trackKilometers = 0;
string[,] fild = new string[sizeSquareMatrix, sizeSquareMatrix];
for (int i = 0; i < sizeSquareMatrix; i++)
{
    string[] currentLine = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries);

    for (int n = 0; n < currentLine.Length; n++)
    {
        fild[i, n] = currentLine[n];
    }
}

int row = 0;
int col = 0;
bool isFinish = false; ;
string command = string.Empty;
while ((command = Console.ReadLine()) != "End")
{


    if (command == "left")
    {
        col--;
        trackKilometers += 10;
        if (fild[row, col] == "T")
        {
            fild[row, col] = ".";
            for (int rows = row; rows < fild.GetLength(0); rows++)
            {
                for (int cols = 0; cols < fild.GetLength(1); cols++)
                {
                    if (fild[rows, cols] == "T")
                    {
                        fild[rows, cols] = ".";
                        row = rows;
                        col = cols;
                        trackKilometers += 20;
                    }
                }
            }
        }
        if (fild[row, col] == "F")
        {
            fild[row, col] = "C";
            Console.WriteLine($"Racing car {racingNumber} finished the stage!");
            isFinish = true;
            break;
        }

    }
    else if (command == "right")
    {
        col++;
        trackKilometers += 10;
        if (fild[row, col] == "T")
        {
            fild[row, col] = ".";
            for (int rows = row; rows < fild.GetLength(0); rows++)
            {

                for (int cols = 0; cols < fild.GetLength(1); cols++)
                {
                    if (fild[rows, cols] == "T")
                    {
                        fild[rows, cols] = ".";
                        row = rows;
                        col = cols;
                        trackKilometers += 20;
                    }
                }
            }
        }
        if (fild[row, col] == "F")
        {
            fild[row, col] = "C";
            Console.WriteLine($"Racing car {racingNumber} finished the stage!");
            isFinish = true;
            break;
        }
    }
    else if (command == "up")
    {
        row--;
        trackKilometers += 10;
        if (fild[row, col] == "T")
        {
            fild[row, col] = ".";
            for (int rows = row; rows < fild.GetLength(0); rows++)
            {
                for (int cols = 0; cols < fild.GetLength(1); cols++)
                {
                    if (fild[rows, cols] == "T")
                    {
                        fild[rows, cols] = ".";
                        row = rows;
                        col = cols;
                        trackKilometers += 20;
                    }
                }
            }
        }
        if (fild[row, col] == "F")
        {
            fild[row, col] = "C";
            Console.WriteLine($"Racing car {racingNumber} finished the stage!");
            isFinish = true;
            break;
        }
    }
    else if (command == "down")
    {
        row++; ;
        trackKilometers += 10;
        if (fild[row, col] == "T")
        {
            fild[row, col] = ".";
            for (int rows = row; rows < fild.GetLength(0); rows++)
            {
                for (int cols = 0; cols < fild.GetLength(1); cols++)
                {
                    if (fild[rows, cols] == "T")
                    {
                        fild[rows, cols] = ".";
                        row = rows;
                        col = cols;
                        trackKilometers += 20;
                    }
                }
            }
        }
        if (fild[row, col] == "F")
        {
            fild[row, col] = "C";
            Console.WriteLine($"Racing car {racingNumber} finished the stage!");
            isFinish = true;
            break;
        }
    }


}


if (isFinish)
{
    Console.WriteLine($"Distance covered {trackKilometers} km.");
    for (int r = 0; r < fild.GetLength(0); r++)
    {
        for (int c = 0; c < fild.GetLength(1); c++)
        {
            Console.Write(fild[r, c]);
        }
        Console.WriteLine();
    }

}
else
{
    fild[row, col] = "C";
    Console.WriteLine($"Racing car {racingNumber} DNF.");
    Console.WriteLine($"Distance covered {trackKilometers} km.");
    for (int r = 0; r < fild.GetLength(0); r++)
    {
        for (int c = 0; c < fild.GetLength(1); c++)
        {
            Console.Write(fild[r, c]);

        }
        Console.WriteLine();
    }

}



