using System;
using System.Diagnostics.Metrics;

namespace Practice2
{
    class Start
    {
        static void creat_mass(ref int mass)
        {
            mass = mass * (-1);
        }

        static void Main(string[] args)
        {
            int nomber = Convert.ToInt32(Console.ReadLine());
            creat_mass(ref nomber);
            Console.WriteLine(nomber);
        }
    }
}
