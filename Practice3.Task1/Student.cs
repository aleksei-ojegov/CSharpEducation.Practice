using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3.Task1
{
    class Student
    {
        public string name = "Joe";
        public int age = 19;

        public void get_student_info()
        {
            Console.WriteLine($"Name {name}, age {age}");
        }
    }
}
