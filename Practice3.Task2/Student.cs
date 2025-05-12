using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3.Task2
{
    class Student
    {
        int score = 0;
        public string name = "Joe";
        public int age = 19;

        public void get_student_info()
        {
            Console.WriteLine($"Name {name}, age {age}");
        }

        public int average_score
        {
            get
            {
                return score;
            }
            set
            {
                if (value < 0 || value > 5)
                    Console.WriteLine("Средний балл должен быть от 0 до 5");
                else
                    score = value;
            }
        }
    }
}
