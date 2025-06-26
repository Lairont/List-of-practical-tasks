using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp46
{
    class Program
    {
        // Метод, применяющий два преобразования последовательно
        public static double Calculate(double number, ICalculation op1, ICalculation op2)
        {
            double result1 = op1.Perform(number);
            double result2 = op2.Perform(result1);
            return result2;
        }

        static void Main(string[] args)
        {
            double input = 10.0;

            // Первое преобразование: +5
            ICalculation add = new Add(5);

            // Второе преобразование: *2
            ICalculation multiply = new Multiply(2);

            double result = Calculate(input, add, multiply);

            Console.WriteLine($"Исходное число: {input}");
            Console.WriteLine("Преобразование: сначала +5, потом *2");
            Console.WriteLine($"Результат: {result}");

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
