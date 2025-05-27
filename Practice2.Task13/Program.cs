using System;
using System.Diagnostics.Metrics;

namespace Practice2
{
    class Start
    {
        static int[,] creat_mass(int row, int col)
        {
            Random random = new Random();
            int[,] mas = new int[row, col];
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    int rand = random.Next(100);
                    mas[i, j] = rand;
                }
            }
            return mas;
        }

        static bool get_mass(int[,] mass)
        {
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    Console.Write(mass[i, j] + " ");
                }
                Console.WriteLine();
            }
            return true;
        }

        static void Main(string[] args)
        {
            Console.Write("Row massiv = ");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.Write("Coll massiv = ");
            int coll = Convert.ToInt32(Console.ReadLine());
            int[,] mass = creat_mass(row, coll);
            get_mass(mass);
        }
    }
}
