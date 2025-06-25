using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass(); // Создаём объект класса MyClass

            Console.WriteLine("Вызов метода, возвращающего число типа int: {0}", myClass.GetIntNumber());
            Console.WriteLine("Вызов метода, возвращающего число PI: {0}", myClass.GetPi());
            Console.WriteLine("Вызов метода, возвращающего x в квадрате: {0}", myClass.GetSquare(3));
            Console.WriteLine("Вызов метода, возвращающего корень квадратный из x: {0}", myClass.GetSqrt(6.25));
            Console.WriteLine("Вызов метода, возвращающего число типа int: {0}", myClass.GetIntNumber());

            Console.ReadKey(); 
        }
    }
}

