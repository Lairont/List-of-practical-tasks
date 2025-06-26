using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp500
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите год:");
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите месяц:");
            int month = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите день:");
            int day = int.Parse(Console.ReadLine());

            // 2. Создаем объект класса с использованием конструктора с параметрами
            DateClass myDate = new DateClass(year, month, day);

            Console.WriteLine("Введённая дата: {0}", myDate.Data.ToShortDateString());

            Console.WriteLine("Предыдущий день: {0}", myDate.PreviousDay().ToShortDateString());
            Console.WriteLine("Следующий день: {0}", myDate.NextDay().ToShortDateString());

            Console.ReadKey();
        }
    }
}
