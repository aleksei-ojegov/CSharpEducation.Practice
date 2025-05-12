using System;
using System.Diagnostics.Metrics;

namespace Practice2
{
    class Start
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int lenght = random.Next(1, 100);

            while (true)
            {
                int chek = Convert.ToInt32(Console.ReadLine());
                if (chek == lenght)
                {
                    Console.WriteLine("You win");
                    break;
                }
            }

        }
    }
}
