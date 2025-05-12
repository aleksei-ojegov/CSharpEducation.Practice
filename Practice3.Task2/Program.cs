namespace Practice3.Task2
{
    class Start
    {
        static void Main()
        {
            Student student = new Student();
            student.get_student_info();
            student.average_score = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(student.average_score);
        }
    }
}
