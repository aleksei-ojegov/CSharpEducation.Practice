using System;

namespace Practice2
{
    class Start
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a: ");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i.ToString());
            }
            Console.WriteLine("");
            Console.WriteLine("b: ");
            int j = 5;
            while (j > 0)
            {
                Console.WriteLine(j.ToString());
                j--;
            }
            Console.WriteLine("");
            Console.WriteLine("c: ");
            int c = 5;
            do
            {
                Console.WriteLine(c.ToString());
                c--;
            }
            while (c > 0);
            Console.WriteLine("");
            Console.WriteLine("d: ");
            string word = Console.ReadLine();
            for (int i = 0; i < word.Length; i++)
            {
                Console.Write(word[i] + " ");
            }
            Console.WriteLine("");
            Console.WriteLine("e: ");
            string word_e = Console.ReadLine();
            int count_e = word_e.Length;
            while (count_e > 0)
            {
                Console.Write(word_e[word_e.Length - count_e] + " ");
                count_e--;
            }
            Console.WriteLine("");
            Console.WriteLine("f: ");
            string word_f = Console.ReadLine();
            int count_f = word_f.Length;
            do
            {
                Console.Write(word_e[word_e.Length - count_f] + " ");
                count_f--;
            }
            while (count_f > 0);
        }
    }
}