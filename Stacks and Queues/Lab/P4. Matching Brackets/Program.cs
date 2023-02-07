namespace P4._Matching_Brackets
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var stack = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                if (c == '(')
                {
                    stack.Push(i);
                }
                else if (c == ')')
                {
                    int startIndex = stack.Pop();
                    int endIndex = i;

                    string subStr = input.Substring(startIndex, endIndex - startIndex + 1);
                    Console.WriteLine(subStr);
                }


            }

        }
    }
}
