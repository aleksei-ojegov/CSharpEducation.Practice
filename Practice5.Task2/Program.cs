namespace Practice5.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Name cat: ");
            //string name_cat = Console.ReadLine();

            //Console.Write("Age cat: ");
            //int age_cat = Convert.ToInt32(Console.ReadLine());

            //Cat cat = new Cat(name_cat, age_cat);
            //cat.MakeSound();

            //Console.Write("\nName god: ");
            //string name_dog = Console.ReadLine();

            //Console.Write("Age dog: ");
            //int age_dog = Convert.ToInt32(Console.ReadLine());

            //Dog dog = new Dog(name_dog, age_dog);
            //dog.MakeSound();

            //Console.Write("\nName parrot: ");
            //string name_parrot = Console.ReadLine();

            //Console.Write("Age parrot: ");
            //int age_parrot = Convert.ToInt32(Console.ReadLine());

            //Parrot parrot = new Parrot(name_parrot, age_parrot);

            //Console.Write("Tell the parrot: ");
            //string say_parrot = Console.ReadLine();

            //parrot.MakeSound(say_parrot);
            //Console.WriteLine();

            List <Animal> animals = new List<Animal>() { };
            animals.Add(new Dog("Daffy", 4));
            animals.Add(new Cat("Murr", 3));
            animals.Add(new Parrot("Kesha", 12));

            animals[0].MakeSound();
            animals[1].MakeSound();
            ((Parrot)animals[2]).MakeSound("Hello");

            IFlyable[] flyables = new IFlyable[]
            {
                new Parrot("Tesa", 11),
                new Eagle()
            };

            flyables[0].Fly();
            flyables[1].Fly();
        }
    }
}
