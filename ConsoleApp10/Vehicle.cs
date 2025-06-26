using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    abstract class Vehicle
    {
        // Координаты транспортного средства (можно представить как положение на карте)
        public double X { get; set; }
        public double Y { get; set; }

        // Основные параметры транспорта: цена, скорость и год выпуска
        public double Price { get; set; }
        public double Speed { get; set; }
        public int Year { get; set; }

        // Конструктор с параметрами для инициализации всех полей
        public Vehicle(double x, double y, double price, double speed, int year)
        {
            X = x;
            Y = y;
            Price = price;
            Speed = speed;
            Year = year;
        }

        // Абстрактный метод для вывода информации о транспортном средстве.
        // Каждый наследник реализует этот метод по-своему.
        public abstract void ShowInfo();
    }
}
