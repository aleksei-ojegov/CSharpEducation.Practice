using System;
using System.Diagnostics.Metrics;

namespace Practice2
{
    class Start
    {
        static int[] creat_mass(int[] mass)
        {
            int[] mas = new int[mass.Length];
            for (int i = 0; i < mass.Length; i++)
            {
                mas[i] = mass[mass.Length - i - 1];
            }
            return mas;
        }

        static void Main(string[] args)
        {
            int[] source_mass = new int[5] { 1, 2, 3, 4, 5 };
            int[] mass = creat_mass(source_mass);
            for (int i = 0; i < mass.Length; i++)
            {
                Console.WriteLine(mass[i]);
            }
        }
    }
}
