﻿using System;

namespace Excellent_Result
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string password = "s3cr3t!P@ssw0rd";

            if (input == password)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password! Success clone repository!");
            }
            
        }
    }
}
