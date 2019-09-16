using System;
using System.Collections.Generic;
using System.Linq;

namespace StacksAndQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> stack = new Stack<char>();
            string input = Console.ReadLine();
            foreach (var ch in input)
            {
                stack.Push(ch);
            }
            foreach (var ch in stack)
            {
                Console.Write(ch);
            }
            Console.WriteLine();
        }
    }
}
