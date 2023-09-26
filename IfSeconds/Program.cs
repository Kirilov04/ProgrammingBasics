using System;
using System.ComponentModel.Design;

namespace IfSeconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int thirdtime = int.Parse(Console.ReadLine());
            int sum = firstTime + secondTime + thirdtime;
            int minutes = sum / 60;
            int seconds = sum % 60;

            if (seconds < 10)
            {
                Console.WriteLine($"{minutes}:0{seconds}");
            }
            else
            {
                Console.WriteLine($"{minutes}:{seconds}");
            } 
            

        }
    }
}
