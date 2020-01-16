using System;
using System.Collections.Generic;
using System.Text;

namespace _5.GreedyTimes
{
    public class Cash :Itreasure
    {
        public Cash(string name, int amount)
        {
            this.Name = name;
            this.Amount = amount;
        }
        public int Amount { get; set; }
        public string Name { get ; set ; }

        public static int SumAllCurrencies(Dictionary<string,Cash> dict)
        {
            int sum = 0;
            foreach (var currency in dict.Values)
            {
                sum += currency.Amount;
            }
            return sum;
        }
    }
}
