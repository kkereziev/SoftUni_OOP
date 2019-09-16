using System;
using System.Collections.Generic;
using System.Linq;

namespace StacksAndQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                if (input == "Paid")
                {
                    if (queue.Count > 0)
                    {
                        int index = queue.Count;
                        for (int i = 0; i < index; i++)
                        {
                            Console.WriteLine(queue.Dequeue());
                        }
                    }
                }
                else
                {
                    queue.Enqueue(input);
                }
            }
            Console.WriteLine($"{queue.Count} people remaining.");
        }
    }
}
