using System;
using System.Diagnostics.Metrics;

namespace Practice2
{
    class Start
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            Console.WriteLine("a :");
            Console.WriteLine(str.ToUpper());
            Console.WriteLine("b :");
            Console.WriteLine(str.ToLower());
            Console.WriteLine("c :");
            Console.Write((str[0].ToString()).ToUpper());
            for (int i = 1; i < str.Length; i++)
            {
                Console.Write((str[i].ToString()).ToLower());
            }
        }
    }
}
