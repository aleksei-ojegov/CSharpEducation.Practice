using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5.Task1
{
    internal class Contractor : Employee
    {
        public Contractor(string name, int salary) 
            : base(name, salary)
        {
            Name = name;
            Salary = salary;
        }

        public int HourlyRate = 2;

        public new double CalculateBones(int hoursWorked)
        {
            return Math.Round((double)hoursWorked * HourlyRate + Salary, 2);
        }
    }
}
