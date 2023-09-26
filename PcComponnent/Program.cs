using System;

namespace PcComponnent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            int gpuCount = int.Parse(Console.ReadLine());
            int cpuCount = int.Parse(Console.ReadLine());
            int ramCount = int.Parse(Console.ReadLine());
            double gpuCosts = gpuCount * 250;
            double cpuCosts = gpuCosts * (0.35 * gpuCosts);
            double ramPrice = 0.1 * gpuCosts;
            double ramCosts = ramCount * ramPrice;
            double totalCosts = gpuCosts +cpuCosts + ramCosts
                if 




        }
    }
}
