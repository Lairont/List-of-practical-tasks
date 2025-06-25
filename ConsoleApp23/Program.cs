using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ввод строки
            Console.Write("Введите строку: ");
            string input = Console.ReadLine();

            // Вывод доступных цветов
            Console.WriteLine("Доступные цвета:");
            foreach (var colorName in Enum.GetValues(typeof(MyColor)))
            {
                Console.WriteLine($"{(int)colorName}. {colorName}");
            }

            // Ввод номера цвета
            Console.Write("Введите номер цвета: ");
            int colorNumber;
            if (!int.TryParse(Console.ReadLine(), out colorNumber))
            {
                Console.WriteLine("Некорректный ввод номера цвета.");
                return;
            }

            // Печать строки в выбранном цвете
            Printer.Print(input, colorNumber);

            Console.ReadKey();
        }
    }
}
