using System;
using System.Collections.Generic;
using System.Linq;

namespace StacksAndQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            string expr = Console.ReadLine();
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < expr.Length; i++)
            {
                if (expr[i] == '(')
                {
                    stack.Push(i);
                }
                else if (expr[i] == ')')
                {
                    int num = stack.Pop();
                    Console.WriteLine(expr.Substring(num, i - num + 1));
                }
            }
        }
    }
}
