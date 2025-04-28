using System;
using System.Diagnostics.Metrics;

namespace Practice2
{
    class Start
    {
        static void Main(string[] args)
        {
            string strok_a = "Strings";
            Console.WriteLine("String = " + strok_a);
            char charka_a = 's';
            Console.WriteLine("Char = " + charka_a);

            double str_c_a = Convert.ToDouble(strok_a.Length);
            int cha_c_a = 0;

            for (int i = 0; i < strok_a.Length; i++)
            {
                if (charka_a == strok_a[i])
                {
                    cha_c_a++;
                }
            }

            str_c_a = cha_c_a * 100 / str_c_a;
            str_c_a = Math.Round(str_c_a, 2);
            Console.WriteLine("Char % = " + str_c_a);

            Console.Write("String = ");
            string strok = Console.ReadLine();
            Console.Write("Char = ");
            string charka = Console.ReadLine();
            char ka = 'w';
            try
            {
                ka = charka[0];
            }
            catch
            {
                Console.WriteLine("Char not char");
            }

            double str_c = Convert.ToDouble(strok.Length);
            int cha_c = 0;

            for (int i = 0; i < strok.Length; i++)
            {
                if(ka == strok[i])
                {
                    cha_c++;
                }
            }

            str_c = cha_c * 100 / str_c;
            str_c = Math.Round(str_c,2);
            Console.WriteLine("Char % = " + str_c);
        }
    }
}
