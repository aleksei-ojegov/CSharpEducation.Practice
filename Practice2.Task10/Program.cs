using System;
using System.Diagnostics.Metrics;

namespace Practice2
{
    class Start
    {

        static void Main(string[] args)
        {
            int leng = Convert.ToInt32(args[0]);
            int[] mass = new int[leng];
            for (int i = 0; i < leng; i++)
            {
                mass[i] = i + 1;
                Console.WriteLine(mass[i].ToString());
            }
        }
    }
}
