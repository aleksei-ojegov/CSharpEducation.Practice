using System;
using System.Diagnostics.Metrics;

namespace Practice2
{
    class Start
    {
        static int[] creat_mass(int lenght)
        {
            int[] mas = new int[lenght];
            return mas;
        }

        static void Main(string[] args)
        {
            Console.Write("Lenght massiv = ");
            int len = Convert.ToInt32(Console.ReadLine());
            int[] mass = creat_mass(len);
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = i;
                Console.WriteLine(mass[i]);
            }
        }
    }
}