using System;
using System.Diagnostics.Metrics;

namespace Practice2
{
    class Start
    {
        static void creat_mass(ref int a, ref int b)
        {
            (a, b) = (b, a);
        }

        static void Main(string[] args)
        {
            int nomber = Convert.ToInt32(Console.ReadLine());
            int nomber_2 = Convert.ToInt32(Console.ReadLine());
            creat_mass(ref nomber, ref nomber_2);
            Console.WriteLine(nomber + " " + nomber_2);
        }
    }
}
