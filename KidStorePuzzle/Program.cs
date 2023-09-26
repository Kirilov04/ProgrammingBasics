﻿using System;

namespace KidStorePuzzle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tripPrice = double.Parse(Console.ReadLine());
            int puzzle = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());
            double profit = puzzle * 2.6 + dolls * 3 + bears * 4.1 + minions * 8.2 + trucks *2;
            int totalToysCount = puzzle + dolls + bears + minions + trucks;
            if (totalToysCount >= 50)
            profit = profit - 0.25 * profit;
            profit = profit - 0.1 * profit;
            if (profit >= tripPrice)
                Console.WriteLine($"Yes! {profit - tripPrice:f2} lv left.");
            else 
                Console.WriteLine($"Not enough money! {tripPrice - profit:f2} lv needed.");


        }
    }
}
