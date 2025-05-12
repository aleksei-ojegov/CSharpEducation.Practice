using System;

namespace Practice2
{
    class Start
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b = ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("f = ");
            double f = Convert.ToDouble(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("Error, a = 0 ");
            }
            else
            {
                double out_func = (a + b - f / a) + f * a * a - (a + b);
                Console.WriteLine("out_func = " + out_func);
            }
        }
    }
}
