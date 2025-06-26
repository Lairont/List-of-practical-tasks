using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем объекты каждого вида транспорта с параметрами
            Plane plane = new Plane(10, 20, 5000000, 900, 2018, 10000, 150);
            Car car = new Car(15, 25, 30000, 180, 2020);
            Ship ship = new Ship(30, 40, 2000000, 70, 2015, 500, "Одесса");

            // Выводим информацию по каждому объекту
            plane.ShowInfo();
            car.ShowInfo();
            ship.ShowInfo();

            Console.ReadLine();
        }
    }
}

