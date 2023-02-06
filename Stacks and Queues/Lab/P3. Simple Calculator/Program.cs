namespace P3._Simple_Calculator
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            // input.Reverse();
            var stack = new Stack<string>(input.Reverse());

            int num1 = int.Parse(stack.Pop());
            int sum = num1;
            while (stack.Count > 0)
            {
                if (stack.Pop() == "+")
                {
                    int num2 = int.Parse(stack.Pop());
                    sum += num2;

                }
                else
                {
                    int num2 = int.Parse(stack.Pop());
                    sum -= num2;


                }





            }
            Console.WriteLine(sum);



        }
    }
}
