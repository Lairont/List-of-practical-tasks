using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    struct Book
    {
        // Поля структуры
        public string Title;   // Название книги
        public string Author;  // Автор (Ф.И.О.)
        public int Year;       // Год издания
        public int Pages;      // Количество страниц

        // Конструктор структуры
        public Book(string title, string author, int year, int pages)
        {
            Title = title;
            Author = author;
            Year = year;
            Pages = pages;
        }

        // Метод вывода информации о книге
        public void PrintInfo()
        {
            Console.WriteLine("Название: {0}", Title);
            Console.WriteLine("Автор: {0}", Author);
            Console.WriteLine("Год издания: {0}", Year);
            Console.WriteLine("Количество страниц: {0}", Pages);
            Console.WriteLine("-----------------------------------");
        }
    }
}
