using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _51
{
    abstract class Vehicle
    {
        // Общие поля
        public double X { get; set; }
        public double Y { get; set; }
        public double Price { get; set; }
        public double Speed { get; set; }
        public int Year { get; set; }

        public Vehicle(double x, double y, double price, double speed, int year)
        {
            X = x;
            Y = y;
            Price = price;
            Speed = speed;
            Year = year;
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine($"Координаты: ({X}, {Y}), Цена: {Price} руб, Скорость: {Speed} км/ч, Год выпуска: {Year}");
        }
    }
}
