using System;
using System.Diagnostics.Metrics;

namespace Practice2
{
    class Start
    {

        static void Main(string[] args)
        {
            int leng = Convert.ToInt32(args[0]);
            int items_mas = Convert.ToInt32(args[1]);
            int[] mass = new int[leng];
            for (int i = 0; i < leng; i++)
            {
                mass[i] = items_mas;
                Console.WriteLine(mass[i].ToString());
            }
        }
    }
}
