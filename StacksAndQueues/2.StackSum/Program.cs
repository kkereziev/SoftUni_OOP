using System;
using System.Collections.Generic;
using System.Linq;

namespace StacksAndQueues
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(input);
            string inputStr;
            while ((inputStr = Console.ReadLine().ToLower()) != "end")
            {
                string[] inputArgs = inputStr.Split();
                switch (inputArgs[0])
                {
                    case "add":
                        int numOne = int.Parse(inputArgs[1]);
                        int numTwo = int.Parse(inputArgs[2]);
                        stack.Push(numOne);
                        stack.Push(numTwo);
                        break;
                    case "remove":
                        int count = int.Parse(inputArgs[1]);
                        if (count < stack.Count)
                        {
                            while (count > 0)
                            {
                                stack.Pop();
                                count--;
                            }
                        }
                        break;
                }
            }
            int sum = 0;
            foreach (var num in stack)
            {
                sum += num;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
