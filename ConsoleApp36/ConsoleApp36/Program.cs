﻿using System;

namespace ConsoleApp36
{
    class MyClass
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            double sum = 0;
            for (double i = 1; i <= n; i++)
            {
                sum += 1/i;
                Console.WriteLine(sum);
            }
        }
    }
}

