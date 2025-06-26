using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp49
{
    class Point
    {
        private int x;
        private int y;

        // Статические счетчики
        private static int countQ1 = 0;
        private static int countQ2 = 0;
        private static int countQ3 = 0;
        private static int countQ4 = 0;
        private static int totalCount = 0;

        // Конструктор с параметрами
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;

            totalCount++;

            // Определение координатной четверти
            if (x > 0 && y > 0)
                countQ1++;
            else if (x < 0 && y > 0)
                countQ2++;
            else if (x < 0 && y < 0)
                countQ3++;
            else if (x > 0 && y < 0)
                countQ4++;
        }

        // Метод: вывод координат
        public void Show()
        {
            Console.WriteLine($"Точка: ({x}, {y})");
        }

        // Статический метод: вывод статистики
        public static void ShowStats()
        {
            Console.WriteLine("\nСтатистика точек по координатным четвертям:");
            Console.WriteLine($"1-я четверть: {countQ1}");
            Console.WriteLine($"2-я четверть: {countQ2}");
            Console.WriteLine($"3-я четверть: {countQ3}");
            Console.WriteLine($"4-я четверть: {countQ4}");
            Console.WriteLine($"Общее количество точек: {totalCount}");
        }
    }
}
