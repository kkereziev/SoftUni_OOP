using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.GreedyTimes
{
    class StartUp
    {
        static void Main(string[] args)
        {
            /*
            <Gold> $10300000
            ##Gold - 10300000
            <Gem> $10290000
            ##Topazgem - 290000
            ##Rubygem - 10000000
            <Cash> $3410010
            ##KLM - 3120010
            ##JPN - 10000
            ##CHF - 280000
             */
            int capacity = int.Parse(Console.ReadLine());
            Bag bag = new Bag(capacity);
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < input.Length; i+=2)
            {
                var gemAmount = bag.SumGemsAmount();
                var currenciesAmount = bag.SumCurrenciesAmount();
                string currentTresure =input[i];
                int amount = int.Parse(input[i+1]);
                if (currentTresure.Length==3)
                {
                    if (gemAmount < currenciesAmount+amount)
                    {
                        continue;
                    }
                    if (!bag.Currencies.Any(x=>x.Name.ToLower()==currentTresure.ToLower()))
                    {
                        bag.Currencies.Add(new Cash(currentTresure, amount));
                    }
                    else
                    {
                        var tres = bag.Currencies.FirstOrDefault(x => x.Name.ToLower() == currentTresure.ToLower());
                        tres.Amount += amount;
                    }
                }
                else if (currentTresure.ToLower().EndsWith("gem"))
                {
                    if (bag.Gold.Amount<gemAmount+amount)
                    {
                        continue;
                    }
                    if (!bag.Gems.Any(x=>x.Name.ToLower()==currentTresure.ToLower()))
                    {
                        bag.Gems.Add(new Gem(currentTresure,amount));
                    }
                    else
                    {
                        var gem = bag.Gems.FirstOrDefault(x => x.Name.ToLower() == currentTresure.ToLower());
                        gem.Amount += amount;
                    }
                }
                else
                {
                    bag.Gold.Amount += amount;
                }
            }
            //TODO : da napravq sorting(trqbva mai da se napravi nov, subiratelen, klas, za da moje da se sortirat)
        }
    }
}
