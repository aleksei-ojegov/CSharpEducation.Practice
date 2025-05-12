using System;
using System.Diagnostics.Metrics;

namespace Practice2
{
    class Start
    {
        static void creat_mass(ref int[] mass, out int b)
        {
            b = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] < 0)
                {
                    b++;
                }
            }
            mass = mass.Where(val => val > 0).ToArray();
        }

        static void Main(string[] args)
        {
            int[] mass = new int[5] { 1, -2, -3, 4, 5 };
            int cout_neg = 0;
            creat_mass(ref mass, out cout_neg);
            for (int i = 0; i < mass.Length; i++)
            {
                Console.WriteLine(mass[i]);
            }
            Console.WriteLine(cout_neg);
        }
    }
}
