using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Calculator
    {
        // Метод сложения
        public static double Add(double a, double b)
        {
            return a + b;
        }

        // Метод вычитания
        public static double Subtract(double a, double b)
        {
            return a - b;
        }

        // Метод умножения
        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        // Метод деления
        public static double Divide(double a, double b)
        {
            if (b != 0)
                return a / b;
            else
            {
                Console.WriteLine("Ошибка: деление на ноль!");
                return double.NaN; // Возвращаем "не число", если деление невозможно
            }
        }
    }
}