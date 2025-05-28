using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5.Task2
{
    internal class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Woof!");
        }

        public Dog(string name, int age) : base(name, age)
        {
            Console.WriteLine($"Creat dog {name}, age {age}");
        }
    }
}
