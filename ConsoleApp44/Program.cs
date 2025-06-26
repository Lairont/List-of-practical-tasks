using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp44
{
    class Program
    {
        // а) Статический метод для вычисления суммы от m до n
        public static int Sum(int m, int n)
        {
            int total = 0;
            for (int i = m; i <= n; i++)
            {
                total += i;
            }
            return total;
        }

        // б) Объявление типа делегата
        public delegate int SumDelegate(int m, int n);

        static void Main(string[] args)
        {
            // в) Создание делегата
            SumDelegate sumDelegate = new SumDelegate(Sum);

            // г) Применение делегата 3 раза
            int result1 = sumDelegate(1, 5);
            Console.WriteLine($"Сумма от 1 до 5: {result1}");

            int result2 = sumDelegate(10, 20);
            Console.WriteLine($"Сумма от 10 до 20: {result2}");

            int result3 = sumDelegate(-3, 3);
            Console.WriteLine($"Сумма от -3 до 3: {result3}");

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}