namespace Practice3.Task9
{
    class Start
    {
        static void rename(Student student)
        {
            student.name = "Tom";
        }

        static void Main()
        {
            Student student = new Student();
            rename(student);
            Console.WriteLine($"Student name - {student.name}");
        }
    }
}
