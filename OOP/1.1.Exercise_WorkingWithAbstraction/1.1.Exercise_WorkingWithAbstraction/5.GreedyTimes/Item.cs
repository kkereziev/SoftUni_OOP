using System;
using System.Collections.Generic;
using System.Text;

namespace _5.GreedyTimes
{
    public abstract class Item 
    {
        protected Item(string key, long value)
        {
            this.Key = key;
            this.Value = value;
        }
        public string Key { get ;  protected set ; }
        public long Value { get ;  protected set ; }

        public void IncreaseValue(long value)
        {
            this.Value += value;
        }
    }
}
