using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp45
{
    class Program
    {
        // Метод вывода информации о фигуре
        public static void PrintShapeInfo(IShape shape)
        {
            Console.WriteLine($"Фигура: {shape.Name}");
            Console.WriteLine(shape.GetInfo());
            Console.WriteLine($"Периметр: {shape.Perimeter():F2}");
            Console.WriteLine($"Площадь: {shape.Area():F2}");
            Console.WriteLine(new string('-', 40));
        }

        static void Main(string[] args)
        {
            // Примеры фигур
            IShape triangle = new Triangle(3, 4, 5);
            IShape disk = new Disk(7);

            // Вывод информации
            PrintShapeInfo(triangle);
            PrintShapeInfo(disk);

            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}