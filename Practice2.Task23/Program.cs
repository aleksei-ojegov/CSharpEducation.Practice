using System;
using System.Diagnostics.Metrics;

namespace Practice2
{
    class Start
    {
        static void Main(string[] args)
        {
            int year = Convert.ToInt32(Console.ReadLine());
            if (year % 400 == 0)
            {
                Console.WriteLine($"{year} - високосный год");
            }
            else if (year % 100 == 0)
            {
                Console.WriteLine($"{year} - невисокосный год");
            }
            else if (year % 4 == 0)
            {
                Console.WriteLine($"{year} - високосный год");
            }
            else
            {
                Console.WriteLine($"{year} - невисокосный год");
            }
        }
    }
}

