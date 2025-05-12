using System;
using System.Diagnostics.Metrics;

namespace Practice2
{
    class Start
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int lenght = random.Next(10);
            int coll = random.Next(10);
            int[,] mass = new int[lenght, coll];

            for (int i = 0; i < lenght; i++)
            {
                for (int j = 0; j < coll; j++)
                {
                    mass[i, j] = random.Next(1, 100);
                }
            }


            for (int i = 0; i < lenght; i++)
            {
                int min = 100;
                int max = 1;
                for (int j = 0; j < coll; j++)
                {
                    if (mass[i, j] < min)
                    {
                        min = mass[i, j];
                    }
                    if (mass[i, j] > max)
                    {
                        max = mass[i, j];
                    }
                }
                Console.WriteLine(max - min);
            }
        }
    }
}
