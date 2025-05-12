using System;

class Class
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");
        string reshenie = Console.ReadLine();

        if (reshenie == "a")
        {
            double katet = Convert.ToDouble(Console.ReadLine());
            double katet_2 = Convert.ToDouble(Console.ReadLine());
            double gipotit = Math.Sqrt(Math.Pow(katet, 2) + Math.Pow(katet_2, 2));
            Console.WriteLine($"Gipotit = {gipotit}");
        }
        if (reshenie == "b")
        {
            Console.WriteLine("Katet");
            double katet = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Gipotit");
            double gipotit = Convert.ToDouble(Console.ReadLine());
            double katet_2 = Math.Sqrt(Math.Pow(gipotit, 2) - Math.Pow(katet, 2));
            Console.WriteLine(Math.Pow(katet, 2));
            Console.WriteLine(Math.Pow(gipotit, 2));
            Console.WriteLine(Math.Sqrt(25 - 16));
            Console.WriteLine($"Katet 2 = {katet_2}");
        }
    }
}
