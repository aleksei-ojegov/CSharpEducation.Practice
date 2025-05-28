using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5.Task2
{
    internal class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow!");
        }

        public Cat(string name, int age) : base(name, age)
        {
            Console.WriteLine($"Creat cat {name}, age {age}");
        }
    }
}
