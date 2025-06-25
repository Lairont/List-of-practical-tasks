using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    interface IMyInterface
    {
        double GetPi();       // Метод, возвращающий число Pi
        int GetIntNumber();   // Метод, возвращающий целое число
        double GetSquare(double x); // Метод, возвращающий x в квадрате
        double GetSqrt(double x);   // Метод, возвращающий корень квадратный из x
    }
}
