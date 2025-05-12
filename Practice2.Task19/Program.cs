using System;
using System.Diagnostics.Metrics;

namespace Practice2
{
    class Start
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int lenght = random.Next(100);
            int[] mass = new int[lenght];

            for (int i = 0; i < lenght; i++)
            {
                mass[i] = random.Next(1, 100);
            }

            int min = 100;
            int max = 1;
            for (int i = 0; i < lenght; i++)
            {
                if (mass[i] < min)
                {
                    min = mass[i];
                }
                if (mass[i] > max)
                {
                    max = mass[i];
                }
            }

            Console.WriteLine(max - min);
        }
    }
}
