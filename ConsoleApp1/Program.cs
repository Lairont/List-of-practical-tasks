using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Первая сторона: ");
            double side1 = double.Parse(Console.ReadLine());
            Console.Write("Вторая сторона: ");
            double side2 = double.Parse(Console.ReadLine());
            Rectangle rec = new Rectangle(side1, side2);
            Console.WriteLine($"Площадь: {rec.AreaCalculator()}");
            Console.WriteLine($"Периметр: {rec.PerimeterCalculator()}");
            Console.ReadKey();
             
        }
    }
}
