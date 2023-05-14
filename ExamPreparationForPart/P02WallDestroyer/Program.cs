using System;

namespace P02WallDestroyer
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
                    if (fild[r, c] == "V")
                    {
                        rows = r;
                        cols = c;
                    }
                }
            }
            int holeCounter = 0;
            int countRods = 0;
            string command = string.Empty;
            bool isVankoDead = false;
            bool isInWhile = false;
            while ((command = Console.ReadLine()) != "End")
            {

                isInWhile = true;
                if (command == "up")
                {
                    if (ValidIndex(fild, rows - 1, cols))
                    {
                        fild[rows, cols] = "*";
                        rows--;
                        if (fild[rows, cols] == "R")
                        {
                            countRods++;
                            rows++;
                            fild[rows, cols] = "V";
                            Console.WriteLine("Vanko hit a rod!");
                        }
                        else if (fild[rows, cols] == "C")
                        {
                            isVankoDead = true;
                            fild[rows, cols] = "E";
                            holeCounter++;
                            break;

                        }
                        else if (fild[rows, cols] != "-")
                        {

                            Console.WriteLine($"The wall is already destroyed at position [{rows}, {cols}]!");
                        }
                        else
                        {
                            holeCounter++;
                            fild[rows, cols] = "V";
                        }


                    }



                }
                else if (command == "down")
                {
                    if (ValidIndex(fild, rows + 1, cols))
                    {
                        fild[rows, cols] = "*";
                        rows++;
                        if (fild[rows, cols] == "R")
                        {
                            countRods++;
                            rows--;
                            fild[rows, cols] = "V";
                            Console.WriteLine("Vanko hit a rod!");
                        }
                        else if (fild[rows, cols] == "C")
                        {
                            isVankoDead = true;
                            fild[rows, cols] = "E";
                            holeCounter++;
                            break;

                        }
                        else if (fild[rows, cols] != "-")
                        {
                            Console.WriteLine($"The wall is already destroyed at position [{rows}, {cols}]!");
                        }
                        else
                        {
                            holeCounter++;
                            fild[rows, cols] = "V";
                        }


                    }





                }
                else if (command == "left")
                {
                    if (ValidIndex(fild, rows, cols - 1))
                    {
                        fild[rows, cols] = "*";
                        cols--;
                        if (fild[rows, cols] == "R")
                        {
                            countRods++;
                            cols++;
                            fild[rows, cols] = "V";
                            Console.WriteLine("Vanko hit a rod!");
                        }
                        else if (fild[rows, cols] == "C")
                        {
                            isVankoDead = true;
                            fild[rows, cols] = "E";
                            holeCounter++;
                            break;

                        }
                        else if (fild[rows, cols] != "-")
                        {
                            Console.WriteLine($"The wall is already destroyed at position [{rows}, {cols}]!");
                        }
                        else
                        {
                            holeCounter++;
                            fild[rows, cols] = "V";
                        }


                    }





                }
                else if (command == "right")
                {
                    if (ValidIndex(fild, rows, cols + 1))
                    {
                        fild[rows, cols] = "*";
                        cols++;
                        if (fild[rows, cols] == "R")
                        {
                            countRods++;
                            cols--;
                            fild[rows, cols] = "V";
                            Console.WriteLine("Vanko hit a rod!");
                        }
                        else if (fild[rows, cols] == "C")
                        {
                            isVankoDead = true;
                            fild[rows, cols] = "E";
                            holeCounter++;
                            break;

                        }
                        else if (fild[rows, cols] != "-")
                        {
                            Console.WriteLine($"The wall is already destroyed at position [{rows}, {cols}]!");
                        }
                        else
                        {
                            holeCounter++;
                            fild[rows, cols] = "V";
                        }


                    }


                }

            }
            if (isInWhile)
            {
                holeCounter++;
            }

            if (!isVankoDead)
            {
                Console.WriteLine($"Vanko managed to make {holeCounter} hole(s) and he hit only {countRods} rod(s).");
            }
            else
            {
                Console.WriteLine($"Vanko got electrocuted, but he managed to make {holeCounter} hole(s).");
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
