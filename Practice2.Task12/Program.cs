using System;
using System.Diagnostics.Metrics;

namespace Practice2
{
    class Start
    {

        static void Main(string[] args)
        {
            Console.Write("Lenght massiv = ");
            int leng = Convert.ToInt32(Console.ReadLine());

            string[] mass = new string[leng];
            for (int i = 0; i < leng; i++)
            {
                mass[i] = Console.ReadLine();
            }

            for (int i = 0; i < leng; i++)
            {
                Console.WriteLine(mass[i]);
            }
        }
    }
}
