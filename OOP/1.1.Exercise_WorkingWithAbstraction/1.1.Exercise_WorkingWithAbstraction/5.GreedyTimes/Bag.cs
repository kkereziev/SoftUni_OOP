using System;
using System.Collections.Generic;
using System.Text;

namespace _5.GreedyTimes
{
    public class Bag
    {
        public Bag(int capacity)
        {
            this.Currencies = new List<Cash>();
            this.Gems = new List<Gem>();
            this.BagCapacity = capacity;
            this.Gold = new Gold();
        }
        public List<Cash> Currencies { get; set; }
        public List<Gem> Gems { get; set; }
        public Gold Gold { get; set; }
        public int BagCapacity { get; private set; }

        public int SumCurrenciesAmount()
        {
            if (this.Currencies.Count==0)
            {
                return -2;
            }
            else
            {
                int sum = 0;
                foreach (var curr in this.Currencies)
                {
                    sum += curr.Amount;
                }
                return sum;
            }
            
        }
        public int SumGemsAmount()
        {
            if (this.Gems.Count == 0)
            {
                return -1;
            }
            else
            {
                int sum = 0;
                foreach (var gem in this.Gems)
                {
                    sum += gem.Amount;
                }
                return sum;
            }
        }
    }
}
