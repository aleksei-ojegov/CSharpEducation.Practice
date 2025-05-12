using System;

class Class
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");


        int age_other = 0;
        string name = "";
        double tempare = 0;
        bool female = true;

        int age_me = 27;
        string name_me = "Aleksei";
        string compani = "IRZ";
        bool nastroi = false;
        double ves = 85.6;

        Console.WriteLine("Tvoe ima ?");
        name = Console.ReadLine();
        Console.WriteLine($"Privet {name}");

        string nam1 = Console.ReadLine();
        string nam2 = Console.ReadLine();
        Console.WriteLine(nam1 + " " + nam2);


    }
}
