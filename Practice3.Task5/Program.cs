namespace Practice3.Task5
{
    class Start
    {
        static void Main()
        {
            Console.Write("Title : ");
            string title1 = Console.ReadLine();
            Book book1 = new Book(title1);

            Console.Write("Title : ");
            string title2 = Console.ReadLine();
            Console.Write("Author : ");
            string author2 = Console.ReadLine();
            Book book2 = new Book(title2, author2);

            Console.Write("Title : ");
            string title3 = Console.ReadLine();
            Console.Write("Author : ");
            string author3 = Console.ReadLine();
            Console.Write("Public date : ");
            string data3 = Console.ReadLine();
            Book book3 = new Book(title3, author3, data3);
        }
    }
}
