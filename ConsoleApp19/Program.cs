using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 5;

            Console.WriteLine("Операнды: a = {0}, b = {1}\n", a, b);

            Console.WriteLine("Сложение: {0}", Calculator.Add(a, b));
            Console.WriteLine("Вычитание: {0}", Calculator.Subtract(a, b));
            Console.WriteLine("Умножение: {0}", Calculator.Multiply(a, b));
            Console.WriteLine("Деление: {0}", Calculator.Divide(a, b));

            Console.ReadKey();
        }
    }
}
