using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5.Task1
{
    internal class Employee
    {
        public string Name;
        public int Salary;

        public double CalculateBones()
        {
            return Math.Round((double)Salary * 0.1,2);
        }

        public Employee(string name, int salary)
        {
            Name = name;
            Salary = salary;
        }
    }
}
