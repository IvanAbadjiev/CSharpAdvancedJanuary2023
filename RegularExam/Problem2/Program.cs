int[] size = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

string[][] fild = new string[size[0]][];

for (int row = 0; row < fild.Length; row++)
    fild[row] = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .ToArray();

int rows = 0;
int cols = 0;
for (int r = 0; r < fild.Length; r++)
{
    for (int c = 0; c < fild[r].Length; c++)
    {
        if (fild[r][c] == "B")
        {
            rows = r;
            cols = c;
        }
    }
}
int opoonentTouch = 0;
int move = 0;
string command = string.Empty;
while ((command = Console.ReadLine()) != "Finish")
{

    if (command == "up")
    {
        if (ValidIndex(fild, rows - 1, cols))
        {
            if (fild[rows - 1][cols] != "O")
            {
                fild[rows][cols] = "-";
                rows--;
                if (fild[rows][cols] == "-")
                {
                    move++;
                    fild[rows][cols] = "B";
                }
                else if (fild[rows][cols] == "P")
                {
                    opoonentTouch++;
                    move++;
                    fild[rows][cols] = "B";
                    if (opoonentTouch == 3)
                    {
                        break;
                    }
                }

            }

        }



    }
    else if (command == "down")
    {
        if (ValidIndex(fild, rows + 1, cols))
        {
            if (fild[rows + 1][cols] != "O")
            {

                fild[rows][cols] = "-";
                rows++;
                if (fild[rows][cols] == "-")
                {
                    move++;
                    fild[rows][cols] = "B";
                }
                else if (fild[rows][cols] == "P")
                {
                    opoonentTouch++;
                    move++;
                    fild[rows][cols] = "B";
                    if (opoonentTouch == 3)
                    {
                        break;
                    }
                }
            }





        }


    }
    else if (command == "left")
    {
        if (ValidIndex(fild, rows, cols - 1))
        {
            if (fild[rows][cols - 1] != "O")
            {

                fild[rows][cols] = "-";
                cols--;
                if (fild[rows][cols] == "-")
                {
                    move++;
                    fild[rows][cols] = "B";
                }
                else if (fild[rows][cols] == "P")
                {
                    opoonentTouch++;
                    move++;
                    fild[rows][cols] = "B";
                    if (opoonentTouch == 3)
                    {
                        break;
                    }
                }
            }





        }

    }
    else if (command == "right")
    {
        if (ValidIndex(fild, rows, cols + 1))
        {
            if (fild[rows][cols + 1] != "O")
            {

                fild[rows][cols] = "-";
                cols++;
                if (fild[rows][cols] == "-")
                {
                    move++;
                    fild[rows][cols] = "B";
                }
                else if (fild[rows][cols] == "P")
                {
                    opoonentTouch++;
                    move++;
                    fild[rows][cols] = "B";
                    if (opoonentTouch == 3)
                    {
                        break;
                    }
                }





            }
        }

    }

}

Console.WriteLine("Game over!");
Console.WriteLine($"Touched opponents: {opoonentTouch} Moves made: {move}");


bool ValidIndex(string[][] fild, int rows, int cols)
{
    if (rows >= 0 && rows < fild.Length)
    {
        if (cols >= 0 && cols < fild[rows].Length)
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