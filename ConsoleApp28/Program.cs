using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем объект класса Tour
            Tour myTour = new Tour();

            Console.WriteLine("Вариант 1 (без параметров):");
            myTour.TourCalc();

            Console.WriteLine("\nВариант 2 (один параметр - страна):");
            myTour.TourCalc("Италия");

            Console.WriteLine("\nВариант 3 (два параметра - страна и количество дней):");
            myTour.TourCalc("Испания", 7);

            Console.ReadKey();
        }
    }
}
