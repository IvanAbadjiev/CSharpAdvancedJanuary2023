namespace P2._Stack_Sum
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(input);
            string command;
            while ((command = Console.ReadLine().ToLower()) != "end")
            {
                string[] cmdArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string cmdType = cmdArgs[0];

                if (cmdType == "add")
                {
                    int n1 = int.Parse(cmdArgs[1]);
                    int n2 = int.Parse(cmdArgs[2]);
                    stack.Push(n1);
                    stack.Push(n2);
                }
                else if (cmdType == "remove")
                {
                    int n1 = int.Parse(cmdArgs[1]);

                    if (stack.Count < n1)
                    {

                    }
                    else
                    {
                        for (int i = 0; i < n1; i++)
                        {
                            stack.Pop();
                        }
                    }

                }


            }
            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}
