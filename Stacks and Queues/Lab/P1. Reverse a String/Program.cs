using System;
using System.Collections;
using System.Collections.Generic;

namespace P1._Reverse_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var stack = new Stack<char>(input);

            foreach (char ch in stack)
            {
                Console.Write(ch);
            }


        }
    }
}
