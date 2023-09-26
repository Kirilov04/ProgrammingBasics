using System;

namespace PaintHouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nylon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int diluent = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            double nylonPrice = (nylon + 2) * 1.5;
            double paintPrice = (paint + 0.1 * paint) * 14.5;
            double diluentPrice = diluent * 5;
            double totalMaterialExpenses = nylonPrice + paintPrice + diluentPrice + 0.4;
            double laborPricePerHour = 0.3 * totalMaterialExpenses;
            double totalLaborPrice = laborPricePerHour * hours;
            Console.WriteLine(totalMaterialExpenses + totalLaborPrice );



        }
    }
}
