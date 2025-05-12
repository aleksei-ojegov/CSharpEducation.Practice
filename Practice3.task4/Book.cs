using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3.Task4
{
    internal class Book
    {
        public string title;
        public string author;

        public Book()
        {
            title = "Неизвестен";
            author = "Unknown";
            Console.WriteLine($"Title {title}, author {author}");
        }

        public Book(string title, string author)
        {
            this.title = title;
            this.author = author;
            Console.WriteLine($"Title {title}, author {author}");
        }
    }
}
