namespace Practice3.Task4
{
    class Start
    {
        static void Main()
        {
            Book book = new Book();

            string title = Console.ReadLine();
            string author = Console.ReadLine();
            Book book1 = new Book(title, author);
        }
    }
}
