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
            int count = int.Parse(Console.ReadLine());
            string input;
            int num = 0;
            while ((input = Console.ReadLine()) != "end")
            {
                if (input == "green")
                {
                    if (queue.Count > 0)
                    {

                        for (int i = 0; i < count; i++)
                        {
                            if (queue.Count <= 0)
                            {
                                break;
                            }
                            Console.WriteLine($"{queue.Dequeue()} passed!");
                            num++;
                        }
                    }
                }
                else
                {
                    queue.Enqueue(input);
                }
            }
            Console.WriteLine($"{num} cars passed the crossroads.");
        }
    }
}
