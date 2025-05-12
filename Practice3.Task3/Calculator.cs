using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Practice3.Task3
{
    internal class Calculator
    {
        public int addition(int summ1, int summ2)
        {
            return summ1 + summ2;
        }

        public int subtraction(int summ1, int summ2)
        {
            return summ1 - summ2;
        }

        public int multiplication(int summ1, int summ2)
        {
            return summ1 * summ2;
        }

        public int division(int summ1, int summ2)
        {
            return summ1 / summ2;
        }
    }
}
