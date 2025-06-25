using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            // Количество книг
            int n = 3;

            // Создаём массив из n книг
            Book[] books = new Book[n];

            // Заполняем массив книг
            books[0] = new Book("Война и мир", "Толстой Л.Н.", 1869, 1300);
            books[1] = new Book("Преступление и наказание", "Достоевский Ф.М.", 1866, 672);
            books[2] = new Book("Мастер и Маргарита", "Булгаков М.А.", 1967, 480);

            // Вывод информации о всех книгах
            Console.WriteLine("Список книг в библиотеке:\n");
            foreach (Book book in books)
            {
                book.PrintInfo();
            }

            Console.ReadKey(); 
        }
    }
}
