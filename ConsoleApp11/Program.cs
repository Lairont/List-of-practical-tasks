using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Author author = new Author("Пушкин");
            Title title = new Title("Евгений Онегин");
            Content content = new Content("Любовь");
            Book book = new Book(author, title, content);
            book.Show();
            Console.Read();
        }
    }
}
