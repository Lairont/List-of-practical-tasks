using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp45
{
    // Интерфейс геометрических фигур
    public interface IShape
    {
        double Perimeter();
        double Area();
        string GetInfo(); // Для вывода параметров фигуры
        string Name { get; } // Название фигуры
    }

    // Класс треугольника
    public class Triangle : IShape
    {
        private double a, b, c;

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double Perimeter()
        {
            return a + b + c;
        }

        public double Area()
        {
            double s = Perimeter() / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c)); // Формула Герона
        }

        public string GetInfo()
        {
            return $"Стороны: a = {a}, b = {b}, c = {c}";
        }

        public string Name => "Треугольник";
    }
}
