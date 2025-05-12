using System;
using System.Diagnostics.Metrics;

namespace Practice2
{
    class Start
    {
        static int[] creat_mass(int number)
        {
            int[] indexs = new int[number];
            for (int i = 0; i < number; i++)
            {
                indexs[i] = i + 1;
            }
            return indexs;
        }

        static bool get_creat_mass(int[] number)
        {
            for (int i = 0; i < number.GetLength(0); i++)
            {
                Console.WriteLine(number[i].ToString());
            }
            return true;
        }

        static void Main(string[] args)
        {
            int mass_count = Convert.ToInt32(Console.ReadLine());
            int[] mass_metod = creat_mass(mass_count);
            get_creat_mass(mass_metod);
        }
    }
}
