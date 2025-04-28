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
            int count_try = 10;

            while (true)
            {
                int chek = Convert.ToInt32(Console.ReadLine());
                if (chek == lenght)
                {
                    Console.WriteLine("You win");
                    break;
                }
                else
                {
                    if (chek > lenght)
                    {
                        Console.WriteLine("Число меньше");
                    }
                    else
                    {
                        Console.WriteLine("Число больше");
                    }
                    count_try--;
                    if (count_try == 0)
                    {
                        Console.WriteLine("Ты проиграл");
                        break;
                    }
                    Console.WriteLine("Осталось попыток: " + count_try);
                }
            }

        }
    }
}
