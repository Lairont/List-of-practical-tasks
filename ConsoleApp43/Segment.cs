using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp43
{
    // Обобщённый класс Segment<T>
    public class Segment<T> where T : struct, IConvertible
    {
        // Поля (координаты начальной и конечной точек)
        private T x1, y1, x2, y2;

        // Конструктор
        public Segment(T x1, T y1, T x2, T y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }

        // Свойства доступа
        public T X1
        {
            get => x1;
            set => x1 = value;
        }

        public T Y1
        {
            get => y1;
            set => y1 = value;
        }

        public T X2
        {
            get => x2;
            set => x2 = value;
        }

        public T Y2
        {
            get => y2;
            set => y2 = value;
        }

        // Метод вывода информации об отрезке
        public void Display()
        {
            Console.WriteLine($"Отрезок: начальная точка ({x1}, {y1}), конечная точка ({x2}, {y2})");
        }

        // Метод расчёта длины отрезка
        public double GetLength()
        {
            double dx = Convert.ToDouble(x2) - Convert.ToDouble(x1);
            double dy = Convert.ToDouble(y2) - Convert.ToDouble(y1);
            return Math.Sqrt(dx * dx + dy * dy);
        }
    }
}
