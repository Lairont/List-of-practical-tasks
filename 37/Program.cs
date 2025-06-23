using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37
{
    internal class Program
    {
        // 1. Статический метод для вычисления площади треугольника по сторонам a, b, c (формула Герона)
        public static double S(double a, double b, double c)
        {
            double p = (a + b + c) / 2;          // Полупериметр
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));  // Формула Герона
        }

        // 2. Объявление типа делегата, соответствующего методу S
        public delegate double TriangleAreaDelegate(double a, double b, double c);

        static void Main()
        {
            // 3. Объявление делегата (создаём экземпляр делегата, указываем метод)
            TriangleAreaDelegate areaDelegate = new TriangleAreaDelegate(S);

            // 4. Применяем делегат 3 раза с разными параметрами и выводим результат
            Console.WriteLine("Площадь треугольника 1: " + areaDelegate(3, 4, 5));  // 6
            Console.WriteLine("Площадь треугольника 2: " + areaDelegate(7, 8, 9));
            Console.WriteLine("Площадь треугольника 3: " + areaDelegate(5, 12, 13));

            Console.ReadKey();
        }
    }
}
