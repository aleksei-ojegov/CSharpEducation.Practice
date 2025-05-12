using System;

namespace Practice2
{
    class Start
    {
        static void Main(string[] args)
        {
            Console.WriteLine("metr ?");
            double metr = Convert.ToDouble(Console.ReadLine());
            double kilometr = metr / 1000;
            Console.WriteLine("kilometr = " + kilometr);
            Console.WriteLine();

            double santimetr = kilometr * 1000 * 100;
            Console.WriteLine("santimetr = " + santimetr);
            Console.WriteLine();

            Console.WriteLine("m/sec ?");
            double m_sec = Convert.ToDouble(Console.ReadLine());
            double km_hour = m_sec / 1000 * 3600;
            Console.WriteLine("km_hour = " + km_hour);
            Console.WriteLine();

            Console.WriteLine("C ?");
            double c_temp = Convert.ToDouble(Console.ReadLine());
            double f_temp = c_temp * 9 / 5 + 32;
            Console.WriteLine("f_temp = " + f_temp);
            Console.WriteLine();
        }
    }
}
