namespace Practice5.Task1
{
    class Program
    {
        static void Main()
        {
            Console.Write("Имя сотрудника: ");
            string Name = Console.ReadLine();

            Console.Write("Зарплата сотрудника: ");
            int Salary = Convert.ToInt32(Console.ReadLine());

            Employee employee = new Employee(Name, Salary);

            double bonus = employee.CalculateBones();
            Console.WriteLine($"Бонус сотрудника: {bonus}\n");

            

            Console.Write("Имя менеджера: ");
            string Name_m = Console.ReadLine();

            Console.Write("Зарплата менеджера: ");
            int Salary_m = Convert.ToInt32(Console.ReadLine());

            Console.Write("Размер команды: ");
            int Teamsize = Convert.ToInt32(Console.ReadLine());

            Manager manager = new Manager(Name_m, Salary_m, Teamsize);

            double bonus_m = manager.CalculateBones();
            Console.WriteLine($"Бонус менеджера: {bonus_m}\n");


            Console.Write("Имя подрячика: ");
            string Name_c = Console.ReadLine();

            Console.Write("Зарплата подрячика: ");
            int Salary_c = Convert.ToInt32(Console.ReadLine());

            Contractor contractor = new Contractor(Name_c, Salary_c);

            Console.Write("Часы работы подрячика: ");
            int hoursWorked = Convert.ToInt32(Console.ReadLine());

            double bonus_c = contractor.CalculateBones(hoursWorked);
            Console.WriteLine($"Бонус подрячика: {bonus_c}\n");
        }
    }
}
