using User;

namespace Practice4.Task3
{
    class Start
    {
        static void Main()
        {
            Person person = new();
            person.Name = "Kabachok";
            person.age = 1;

            person.get_person_info();
        }
    }
}

