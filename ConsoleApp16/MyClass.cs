using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class MyClass : IMyInterface
    {
        public double GetPi()
        {
            return Math.PI; // Возвращаем константу PI из стандартной библиотеки
        }

        public int GetIntNumber()
        {
            return 25; // Возвращаем целое число 25
        }

        public double GetSquare(double x)
        {
            return x * x; // Возвращаем квадрат числа x
        }

        public double GetSqrt(double x)
        {
            return Math.Sqrt(x); // Возвращаем квадратный корень из x
        }
    }

}
