using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Car : Vehicle
    {
        // Автомобиль не имеет дополнительных параметров, поэтому только конструктор
        public Car(double x, double y, double price, double speed, int year)
            : base(x, y, price, speed, year)
        {
        }

        // Переопределение ShowInfo для автомобиля
        public override void ShowInfo()
        {
            Console.WriteLine("Автомобиль:");
            Console.WriteLine($"Координаты: X={X}, Y={Y}");
            Console.WriteLine($"Цена: {Price}");
            Console.WriteLine($"Скорость: {Speed} км/ч");
            Console.WriteLine($"Год выпуска: {Year}");
            Console.WriteLine();
        }
    }

}
