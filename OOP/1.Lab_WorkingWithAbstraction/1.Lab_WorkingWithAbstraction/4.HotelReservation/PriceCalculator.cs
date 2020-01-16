using System;
using System.Collections.Generic;
using System.Text;

namespace _4.HotelReservation
{
    public class PriceCalculator
    {
        public static double GetTotalPrice(double pricePerDay, int numberOfDays, Seasons season, DiscountType discountType)
        {
            double sum = pricePerDay * numberOfDays * (int)season;
            double discount = (sum * (int)discountType) / 100;
            sum -= discount;
            return sum;
        }
        public static double GetTotalPrice(double pricePerDay, int numberOfDays, Seasons season)
        {
            double sum = pricePerDay * numberOfDays * (int)season;
            return sum;
        }
    }
}
