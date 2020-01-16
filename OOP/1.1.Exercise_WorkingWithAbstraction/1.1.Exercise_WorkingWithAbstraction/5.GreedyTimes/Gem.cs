using System;
using System.Collections.Generic;
using System.Text;

namespace _5.GreedyTimes
{
    public class Gem : Itreasure
    {
        public Gem(string name, int amount)
        {
            this.Name = name;
            this.Amount = amount;
        }
        public string Name { get ; set ; }
        public int Amount { get ; set ; }
    }
}
