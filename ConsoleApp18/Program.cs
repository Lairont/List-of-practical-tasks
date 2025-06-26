using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            Figura figura = new Figura();

            Console.WriteLine("Расчёт площади различных фигур:\n");

            // Пример для квадрата
            figura.ShowArea(5);

            Console.WriteLine();

            // Пример для прямоугольника
            figura.ShowArea(4, 7);

            Console.WriteLine();

            // Пример для трапеции
            figura.ShowArea(3, 5, 4);

            Console.ReadKey();
        }
    }
}
