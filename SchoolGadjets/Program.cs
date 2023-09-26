using System;

namespace SchoolGadjets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pens = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());
            int preparations = int.Parse(Console.ReadLine());
            int discountPercentage = int.Parse(Console.ReadLine());
            double totalPrice = pens * 5.8 + markers * 7.2 + preparations * 1.2;
            double totalPriceWithDiscount = totalPrice - (totalPrice * discountPercentage * 0.01);
            Console.WriteLine(totalPriceWithDiscount);

        }
    }
}
