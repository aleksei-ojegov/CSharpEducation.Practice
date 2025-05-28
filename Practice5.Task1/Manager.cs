using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Practice5.Task1
{
    internal class Manager : Employee
    {
        public override double CalculateBones()
        {
            if (TeamSize > 5)
                return Math.Round((double)Salary * 0.25, 2);
            else
                return Math.Round((double)Salary * 0.2, 2);
        }

        public int TeamSize;

        public Manager(string name, int salary,int teamsize) 
            : base(name, salary)
        {
            TeamSize = teamsize;
        }
    }
}
