using System;
using System.Diagnostics.Metrics;

namespace Practice2
{
    class Start
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a: ");
            Console.Write("count a = ");
            int count_a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= count_a; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("b: ");
            Console.Write("count b = ");
            int count = Convert.ToInt32(Console.ReadLine());
            Console.Write("symbol b = ");
            string symbol = Console.ReadLine();
            for (int i = 0; i <= count; i++)
            {
                for (int j = count; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int d = 0; d < i; d++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
        }
    }
}

