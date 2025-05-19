namespace User
{
    public class Person
    {
        public string Name;
        public int age;

        public void get_person_info()
        {
            Console.WriteLine($"Name {Name}, age {age}");
        }
    }
}
