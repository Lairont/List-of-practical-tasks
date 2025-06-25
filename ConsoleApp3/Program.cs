using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Point[] points = {
            new Point(0, 0, "Triangle"),
            new Point(3, 0, "Triangle"),
            new Point(0, 4, "Triangle")
        };

            Figure figure = new Figure(points);
            figure.PerimeterCalculator();


            Console.ReadKey();
        }
    }
}
