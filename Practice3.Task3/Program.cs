namespace Practice3.Task3
{
    class Start
    {
        static void Main()
        {
            Calculator calculator = new Calculator();

            Console.WriteLine("Сложение :");
            int summ1 = Convert.ToInt32(Console.ReadLine());
            int summ2 = Convert.ToInt32(Console.ReadLine());
            int add = calculator.addition(summ1, summ2);
            Console.WriteLine(add);

            Console.WriteLine("Вычитание :");
            int sub1 = Convert.ToInt32(Console.ReadLine());
            int sub2 = Convert.ToInt32(Console.ReadLine());
            int sub = calculator.subtraction(sub1, sub2);
            Console.WriteLine(sub);

            Console.WriteLine("Умножение :");
            int mult1 = Convert.ToInt32(Console.ReadLine());
            int mult2 = Convert.ToInt32(Console.ReadLine());
            int mult = calculator.multiplication(mult1, mult2);
            Console.WriteLine(mult);

            Console.WriteLine("Деление :");
            int div1 = Convert.ToInt32(Console.ReadLine());
            int div2 = Convert.ToInt32(Console.ReadLine());
            int div = calculator.division(div1, div2);
            Console.WriteLine(div);
        }
    }
}
