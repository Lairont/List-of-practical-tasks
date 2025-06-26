using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp49
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создание точек
            Point p1 = new Point(3, 4);    // 1-я четверть
            Point p2 = new Point(-2, 5);   // 2-я четверть
            Point p3 = new Point(-4, -6);  // 3-я четверть
            Point p4 = new Point(7, -1);   // 4-я четверть
            Point p5 = new Point(0, 0);    // На осях — не считается в четверти

            // Вывод координат
            p1.Show();
            p2.Show();
            p3.Show();
            p4.Show();
            p5.Show();

            // Вывод статистики
            Point.ShowStats();

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
