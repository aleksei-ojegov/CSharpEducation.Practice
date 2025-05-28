using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5.Task2
{
    internal class Parrot : Animal, IFlyable
    {
        public Parrot(string name, int age) : base(name, age)
        {
            Console.WriteLine($"Creat Parrot {name}, age {age}");
        }

        public string Color { get; set; }

        public new void MakeSound(string words)
        {
            Console.WriteLine($"Parrot is talking {words}");
        }

        public void Fly()
        {
            Console.WriteLine("Parrot is flying");
        }
    }
}
