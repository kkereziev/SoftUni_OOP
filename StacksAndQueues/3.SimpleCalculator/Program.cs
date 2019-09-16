using System;
using System.Collections.Generic;
using System.Linq;

namespace StacksAndQueues
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split().ToArray();
            Stack<string> stack = new Stack<string>(input.Reverse());
            while (stack.Count > 1)
            {
                int numOne = int.Parse(stack.Pop());
                char symbol = char.Parse(stack.Pop());
                int numTwo = int.Parse(stack.Pop());
                int sum = 0;
                if (symbol == '+')
                {
                    sum = numOne + numTwo;
                }
                else if (symbol == '-')
                {
                    sum = numOne - numTwo;
                }
                stack.Push(sum.ToString());
            }
            Console.WriteLine(stack.Peek());
        }
    }
}
