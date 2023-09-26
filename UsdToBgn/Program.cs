using System;
using System.Data.SqlTypes;
using System.Diagnostics.CodeAnalysis;

namespace UsdToBgn
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int points = int.Parse(Console.ReadLine());
            double bonus = 0;
            if (points <= 100)
            {
                bonus = 5;
            }
            else
            {
                bonus = 0.2 * points;
            }
        }
    }
}
