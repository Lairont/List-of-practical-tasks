using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем массив базового типа Printer
            Printer[] printers = new Printer[]
            {
                new Printer(),
                new RedPrinter(),
                new GreenPrinter(),
                new BluePrinter()
            };

            // Перебираем и вызываем метод Print через приведение типов
            foreach (var printer in printers)
            {
                // Явное приведение к типу Printer (по условию задания)
                Printer p = (Printer)printer;
                p.Print("Доброго времени суток!");
            }

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}

