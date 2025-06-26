using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp43
{
    class Program
    {
        static void Main(string[] args)
        {
            // Пример с int
            var segmentInt = new Segment<int>(0, 0, 3, 4);
            segmentInt.Display();
            Console.WriteLine($"Длина: {segmentInt.GetLength():F2}\n");

            // Пример с long
            var segmentLong = new Segment<long>(10000000000, 10000000000, 10000000003, 10000000004);
            segmentLong.Display();
            Console.WriteLine($"Длина: {segmentLong.GetLength():F2}\n");

            // Пример с double
            var segmentDouble = new Segment<double>(1.5, 2.5, 4.5, 6.5);
            segmentDouble.Display();
            Console.WriteLine($"Длина: {segmentDouble.GetLength():F2}\n");

            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
