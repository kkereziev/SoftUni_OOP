using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5.GreedyTimes
{
    public class Bag
    {
        private long current;
        public Bag(long capacity)
        {
            this.Items = new List<Item>();
            this.BagCapacity = capacity;
        }
        public List<Item> Items { get; set; }
        public long BagCapacity { get; private set; }
        public long GoldItemsValue 
        {
            get => this.Items.Where(i => i is Gold).Sum(i => i.Value); 
        }
        public long CashItemsValue 
        {
            get => this.Items.Where(i => i is Cash).Sum(i => i.Value); 
        }
        public long GemItemsValue 
        {
            get => this.Items.Where(i => i is Gem).Sum(i => i.Value); 
        }

        public void AddGoldItem(Gold item) 
        {
            if (IsTrue(item))
            {
                var gold = GetGoldItems();
                if (gold.Any(gi=>gi.Key==item.Key))
                {
                    gold.Single(gi => gi.Key == item.Key).IncreaseValue(item.Value);
                }
                else
                {
                    this.Items.Add(item);
                }
                current += item.Value;
            }
        }
        public void AddGemItem(Gem item)
        {
            if (IsTrue(item) && this.GoldItemsValue>=this.GemItemsValue+item.Value)
            {
                var gems = GetGemItems();
                if (gems.Any(g=>g.Key==item.Key))
                {
                    gems.Single(g => g.Key == item.Key).IncreaseValue(item.Value);
                }
                else
                {
                    this.Items.Add(item);
                }
                current += item.Value;
            }
        }
        public void AddCashItem(Cash item)
        {
            if (IsTrue(item) && this.GemItemsValue >= this.CashItemsValue + item.Value)
            {
                var cash = GetCashItems();
                if (cash.Any(c => c.Key == item.Key))
                {
                    cash.Single(c => c.Key == item.Key).IncreaseValue(item.Value);
                }
                else
                {
                    this.Items.Add(item);
                }
                current += item.Value;
            }
        }

        public List<Item> GetGoldItems()
        {
            return this.Items.Where(x => x is Gold).ToList();
        }
        public List<Item> GetGemItems()
        {
            return this.Items.Where(x => x is Gem).ToList();
        }
        public List<Item> GetCashItems()
        {
            return this.Items.Where(x => x is Cash).ToList();
        }
        public bool IsTrue(Item item)
        {
            bool isTrue = this.BagCapacity >= this.current + item.Value;
            return isTrue;
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            var dictionary = this.Items.GroupBy(i => i.GetType().Name).ToDictionary(kvp => kvp.Key, kvp => kvp.ToList());
            foreach (var kvp in dictionary.OrderByDescending(kv => kv.Value.Sum(i => i.Value)))
            {
                if (kvp.Key == "Cash")
                {
                    sb.AppendLine($"<Cash> ${kvp.Value.Sum(i => i.Value)}");
                }
                else if (kvp.Key == "Gem")
                {
                    sb.AppendLine($"<Gem> ${kvp.Value.Sum(i => i.Value)}");
                }
                else if (kvp.Key == "Gold")
                {
                    sb.AppendLine($"<Gold> ${kvp.Value.Sum(i => i.Value)}");
                }

                foreach (var item in kvp.Value.OrderByDescending(i => i.Key).ThenBy(i => i.Value))
                {
                    sb.AppendLine($"##{item.Key} - {item.Value}");
                }
            }
            return sb.ToString().TrimEnd();
        }
    }
}
