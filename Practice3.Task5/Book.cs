using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3.Task5
{
    internal class Book
    {
        public string title;
        public string author;
        public string public_date;

        public Book()
        {
            title = "Неизвестен";
            author = "Unknown";
            Console.WriteLine($"Title {title}, author {author}");
        }

        public Book(string title) : this(title, "Unknown")
        { }

        public Book(string title, string author) : this(title, author, "Unknown")
        { }

        public Book(string title, string author, string public_date)
        {
            this.title = title;
            this.author = author;
            this.public_date = public_date;
            Console.WriteLine($"Title {title}, author {author}, public_date {public_date}");
        }
    }
}

