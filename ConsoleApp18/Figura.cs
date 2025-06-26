using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Figura
    {
        // Перегруженный метод для квадрата (один параметр - сторона квадрата)
        public void ShowArea(double a)
        {
            double area = a * a;
            Console.WriteLine("Фигура: квадрат");
            Console.WriteLine("Площадь: {0}", area);
        }

        // Перегруженный метод для прямоугольника (два параметра - длина и ширина)
        public void ShowArea(double a, double b)
        {
            double area = a * b;
            Console.WriteLine("Фигура: прямоугольник");
            Console.WriteLine("Площадь: {0}", area);
        }

        // Перегруженный метод для трапеции (три параметра - основания и высота)
        public void ShowArea(double a, double b, double h)
        {
            double area = (a + b) / 2 * h;
            Console.WriteLine("Фигура: трапеция");
            Console.WriteLine("Площадь: {0}", area);
        }
    }
}
