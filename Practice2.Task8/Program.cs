using System;
using System.Diagnostics.Metrics;

namespace Practice2
{
    class Start
    {
        static void Main(string[] args)
        {
            try
            {
                double arg_1 = Convert.ToDouble(Console.ReadLine());
                double arg_2 = Convert.ToDouble(Console.ReadLine());
                double arg_3 = Convert.ToDouble(Console.ReadLine());

                if (arg_1 == arg_2 || arg_2 == arg_3 || arg_1 == arg_3)
                {
                    Console.WriteLine((arg_1 + 5) + " " + (arg_2 + 5) + " " + (arg_3 + 5));
                }
                else
                {
                    Console.WriteLine("равных нет");
                }

            }
            catch
            {
                Console.WriteLine("Error type input");
            }
        }
    }
}
