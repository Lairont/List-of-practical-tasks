using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            // Пример создания структуры через конструктор
            Notebook notebook = new Notebook("Aspire 7", "Acer", 58999.99m);
            notebook.PrintInfo();

            Console.WriteLine();

            // Пример создания структуры с ручным вводом пользователя
            Console.Write("Введите модель ноутбука: ");
            string model = Console.ReadLine();

            Console.Write("Введите производителя: ");
            string manufacturer = Console.ReadLine();

            Console.Write("Введите цену: ");
            decimal price = decimal.Parse(Console.ReadLine());

            Notebook userNotebook = new Notebook(model, manufacturer, price);
            userNotebook.PrintInfo();

            Console.ReadKey();
        }
    }
}
