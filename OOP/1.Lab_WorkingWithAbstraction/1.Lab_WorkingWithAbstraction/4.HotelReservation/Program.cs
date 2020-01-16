using System;
using System.Linq;

namespace _4.HotelReservation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split()
                .ToArray();
            double sum = 0;
            double pricePerDay = double.Parse(input[0]);
            int numberOfDays = int.Parse(input[1]);
            Seasons season = (Seasons)Enum.Parse(typeof(Seasons), input[2]);
            DiscountType discountType = 0;
            if (input.Length > 3)
            {
                discountType = (DiscountType)Enum.Parse(typeof(DiscountType), input[3]);
            }
            if (discountType != 0)
            {
                sum = PriceCalculator.GetTotalPrice(pricePerDay, numberOfDays, season, discountType);
            }
            else
            {
                sum = PriceCalculator.GetTotalPrice(pricePerDay, numberOfDays, season);
            }
            Console.WriteLine($"{sum:f2}");
        }
    }
}
