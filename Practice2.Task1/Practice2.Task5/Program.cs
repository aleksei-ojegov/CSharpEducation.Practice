using System;
using System.Diagnostics.Metrics;

namespace Practice2
{
    class Start
    {
        static void Main(string[] args)
        {
            Console.Write("Первое число = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Второе число = ");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a == b)
            {
                Console.WriteLine("Числа равны");
            }
            else if (b > a)
            {
                Console.WriteLine("Второе число больше первого");
            }
            else
            {
                Console.WriteLine("Первое число больше второго");
            }
        }
    }
}
