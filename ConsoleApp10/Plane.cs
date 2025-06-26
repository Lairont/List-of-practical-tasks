using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Plane : Vehicle
    {
        // Дополнительные свойства самолета: высота полета и количество пассажиров
        public double Height { get; set; }
        public int Passengers { get; set; }

        // Конструктор Plane вызывает конструктор базового класса Vehicle и инициализирует новые поля
        public Plane(double x, double y, double price, double speed, int year, double height, int passengers)
            : base(x, y, price, speed, year)  // Вызов конструктора базового класса
        {
            Height = height;
            Passengers = passengers;
        }

        // Переопределение метода ShowInfo для вывода подробной информации о самолете
        public override void ShowInfo()
        {
            Console.WriteLine("Самолет:");
            Console.WriteLine($"Координаты: X={X}, Y={Y}");
            Console.WriteLine($"Цена: {Price}");
            Console.WriteLine($"Скорость: {Speed} км/ч");
            Console.WriteLine($"Год выпуска: {Year}");
            Console.WriteLine($"Высота: {Height} м");
            Console.WriteLine($"Количество пассажиров: {Passengers}");
            Console.WriteLine();
        }
    }
}
