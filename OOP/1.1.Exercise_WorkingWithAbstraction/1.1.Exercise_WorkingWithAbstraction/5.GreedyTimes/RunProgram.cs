using System;
using System.Collections.Generic;
using System.Text;

namespace _5.GreedyTimes
{
    public class RunProgram
    {
        public static void Run()
        {
            long capacity = long.Parse(Console.ReadLine());
            var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var bag = new Bag(capacity);

            for (int i = 0; i < input.Length; i += 2)
            {
                string key = input[i];
                long value = long.Parse(input[i + 1]);

                InsertItem(key, value, bag);
            }

            Console.WriteLine(bag.ToString());
        }

        private static void InsertItem(string key, long value, Bag bag)
        {
            if (key.Length == 3)
            {
                var cash = new Cash(key, value);
                bag.AddCashItem(cash);
            }
            else if (key.Length >= 4 && key.ToLower().EndsWith("gem"))
            {
                var gem = new Gem(key, value);
                bag.AddGemItem(gem);
            }
            else if (key.ToLower().Equals("gold"))
            {
                var gold = new Gold(key, value);
                bag.AddGoldItem(gold);
            }
        }
    }
}
