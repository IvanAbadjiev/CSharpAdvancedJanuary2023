using System;

namespace P02HelpAMole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fildSize = int.Parse(Console.ReadLine());

            string[,] fild = new string[fildSize, fildSize];

            for (int row = 0; row < fildSize; row++)
            {
                string curentLine = Console.ReadLine();
                string[] arr = new string[curentLine.Length];

                for (int i = 0; i < curentLine.Length; i++)
                {
                    arr[i] = curentLine[i].ToString();
                }

                for (int col = 0; col < arr.Length; col++)
                {
                    fild[row, col] = arr[col];

                }
            }

            int rows = 0;
            int cols = 0;
            for (int r = 0; r < fild.GetLength(0); r++)
            {
                for (int c = 0; c < fild.GetLength(1); c++)
                {
                    if (fild[r, c] == "M")
                    {
                        rows = r;
                        cols = c;
                    }
                }
            }

            int point = 0;
            string command = string.Empty;
            bool isCollectAllPoint = false;
            while ((command = Console.ReadLine()) != "End")
            {
                switch (command)
                {
                    case "up":
                        if (ValidIndex(fild, rows - 1, cols))
                        {
                            fild[rows, cols] = "-";
                            rows--;
                            if (fild[rows, cols] == "S")
                            {
                                fild[rows, cols] = "-";
                                for (int r = 0; r < fild.GetLength(0); r++)
                                {
                                    for (int c = 0; c < fild.GetLength(1); c++)
                                    {
                                        if (fild[r, c] == "S")
                                        {
                                            point -= 3;
                                            rows = r;
                                            cols = c;
                                            fild[rows, cols] = "M";
                                        }
                                    }
                                }
                            }
                            else if (fild[rows, cols] != "-")
                            {
                                point += int.Parse(fild[rows, cols]);
                                fild[rows, cols] = "M";
                                if (point >= 25)
                                {
                                    isCollectAllPoint = true;
                                    break;
                                }
                            }
                            else
                            {
                                fild[rows, cols] = "M";
                            }

                        }
                        else
                        {
                            Console.WriteLine("Don't try to escape the playing field!");
                        }

                        break;
                    case "down":
                        if (ValidIndex(fild, rows + 1, cols))
                        {
                            fild[rows, cols] = "-";
                            rows++;
                            if (fild[rows, cols] == "S")
                            {
                                fild[rows, cols] = "-";
                                for (int r = 0; r < fild.GetLength(0); r++)
                                {
                                    for (int c = 0; c < fild.GetLength(1); c++)
                                    {
                                        if (fild[r, c] == "S")
                                        {
                                            point -= 3;
                                            rows = r;
                                            cols = c;
                                            fild[rows, cols] = "M";
                                        }
                                    }
                                }
                            }
                            else if (fild[rows, cols] != "-")
                            {
                                point += int.Parse(fild[rows, cols]);
                                fild[rows, cols] = "M";
                                if (point >= 25)
                                {
                                    isCollectAllPoint = true;
                                    break;
                                }
                            }
                            else
                            {
                                fild[rows, cols] = "M";
                            }

                        }
                        else
                        {
                            Console.WriteLine("Don't try to escape the playing field!");
                        }


                        break;
                    case "left":
                        if (ValidIndex(fild, rows, cols - 1))
                        {
                            fild[rows, cols] = "-";
                            cols--;
                            if (fild[rows, cols] == "S")
                            {
                                fild[rows, cols] = "-";
                                for (int r = 0; r < fild.GetLength(0); r++)
                                {
                                    for (int c = 0; c < fild.GetLength(1); c++)
                                    {
                                        if (fild[r, c] == "S")
                                        {
                                            point -= 3;
                                            rows = r;
                                            cols = c;
                                            fild[rows, cols] = "M";
                                        }
                                    }
                                }
                            }
                            else if (fild[rows, cols] != "-")
                            {
                                point += int.Parse(fild[rows, cols]);
                                fild[rows, cols] = "M";
                                if (point >= 25)
                                {
                                    isCollectAllPoint = true;
                                    break;
                                }
                            }
                            else
                            {
                                fild[rows, cols] = "M";
                            }

                        }
                        else
                        {
                            Console.WriteLine("Don't try to escape the playing field!");
                        }

                        break;
                    case "right":
                        if (ValidIndex(fild, rows, cols + 1))
                        {
                            fild[rows, cols] = "-";
                            cols++;
                            if (fild[rows, cols] == "S")
                            {
                                fild[rows, cols] = "-";
                                for (int r = 0; r < fild.GetLength(0); r++)
                                {
                                    for (int c = 0; c < fild.GetLength(1); c++)
                                    {
                                        if (fild[r, c] == "S")
                                        {
                                            point -= 3;
                                            rows = r;
                                            cols = c;
                                            fild[rows, cols] = "M";
                                        }
                                    }
                                }
                            }
                            else if (fild[rows, cols] != "-")
                            {
                                point += int.Parse(fild[rows, cols]);
                                fild[rows, cols] = "M";
                                if (point >= 25)
                                {
                                    isCollectAllPoint = true;
                                    break;
                                }
                            }
                            else
                            {
                                fild[rows, cols] = "M";
                            }

                        }
                        else
                        {
                            Console.WriteLine("Don't try to escape the playing field!");
                        }

                        break;
                    default:
                        break;
                }
                if (point >= 25)
                {

                    break;
                }


            }

            if (isCollectAllPoint)
            {
                Console.WriteLine("Yay! The Mole survived another game!");
                Console.WriteLine($"The Mole managed to survive with a total of {point} points.");
            }
            else
            {
                Console.WriteLine("Too bad! The Mole lost this battle!");
                Console.WriteLine($"The Mole lost the game with a total of {point} points.");
            }

            for (int r = 0; r < fild.GetLength(0); r++)
            {
                for (int c = 0; c < fild.GetLength(1); c++)
                {
                    Console.Write(fild[r, c]);
                }
                Console.WriteLine();
            }


        }

        private static bool ValidIndex(string[,] fild, int rows, int cols)
        {
            if (rows >= 0 && rows < fild.GetLength(0))
            {
                if (cols >= 0 && cols < fild.GetLength(1))
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
    }
}
