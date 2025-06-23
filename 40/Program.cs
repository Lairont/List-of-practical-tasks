using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40
{
    internal class Program
    {
    // 1. Статический метод, вычисляющий среднее арифметическое всех целых чисел от m до n включительно
    public static double Average(int m, int n)
        {
            if (n < m)
            {
                // Меняем местами, чтобы цикл был корректным
                int temp = m;
                m = n;
                n = temp;
            }

            int sum = 0;
            int count = 0;

            for (int i = m; i <= n; i++)
            {
                sum += i;
                count++;
            }

            return (double)sum / count;
        }

        // 2. Объявление типа делегата, подходящего под сигнатуру метода Average
        public delegate double AverageDelegate(int m, int n);

        static void Main()
        {
            // 3. Объявление делегата, связанного с методом Average
            AverageDelegate avgDelegate = new AverageDelegate(Average);

            // 4. Применение делегата 3 раза с разными аргументами
            Console.WriteLine("Среднее арифметическое от 1 до 5: " + avgDelegate(1, 5));
            Console.WriteLine("Среднее арифметическое от 10 до 20: " + avgDelegate(10, 20));
            Console.WriteLine("Среднее арифметическое от 7 до 3 (проверка смены порядка): " + avgDelegate(7, 3));
            Console.ReadKey();
        }
    }
}

