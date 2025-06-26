using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Ship : Vehicle
    {
        // Дополнительные свойства корабля: количество пассажиров и порт приписки
        public int Passengers { get; set; }
        public string Port { get; set; }

        // Конструктор Ship вызывает базовый конструктор и инициализирует свои свойства
        public Ship(double x, double y, double price, double speed, int year, int passengers, string port)
            : base(x, y, price, speed, year)
        {
            Passengers = passengers;
            Port = port;
        }

        // Переопределение ShowInfo для вывода информации о корабле
        public override void ShowInfo()
        {
            Console.WriteLine("Корабль:");
            Console.WriteLine($"Координаты: X={X}, Y={Y}");
            Console.WriteLine($"Цена: {Price}");
            Console.WriteLine($"Скорость: {Speed} км/ч");
            Console.WriteLine($"Год выпуска: {Year}");
            Console.WriteLine($"Количество пассажиров: {Passengers}");
            Console.WriteLine($"Порт приписки: {Port}");
            Console.WriteLine();
        }
    }
}
