using System;
using System.Collections.Generic;
using System.Linq;

namespace StacksAndQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>(Console.ReadLine().Split());
            int passCount = int.Parse(Console.ReadLine());
            while (queue.Count > 1)
            {
                for (int i = 0; i < passCount - 1; i++)
                {
                    string player = queue.Dequeue();
                    queue.Enqueue(player);
                }
                Console.WriteLine($"Removed {queue.Dequeue()}");
            }
            Console.WriteLine($"Last is {queue.Peek()}");
        }
    }
}
