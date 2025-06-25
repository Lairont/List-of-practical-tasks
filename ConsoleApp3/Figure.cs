using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Figure
    {
        private Point[] points;

        public Figure(Point[] points)
        {
            this.points = points;
        }

        public double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
        }

        public void PerimeterCalculator()
        {
            double perimeter = 0;
            for (int i = 0; i < points.Length; i++)
            {
                Point current = points[i];
                Point next = points[(i + 1) % points.Length];  // последняя соединяется с первой
                perimeter += LengthSide(current, next);
            }

            Console.WriteLine($"Название фигуры: {points[0].Name}");
            Console.WriteLine($"Периметр: {perimeter:F2}");
        }
    }
}
