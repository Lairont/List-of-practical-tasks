using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создание экземпляра калькулятора
            Calculator calc = new Calculator();

            try
            {
                // Ввод первого числа от пользователя
                Console.Write("Введите первое число: ");
                double a = Convert.ToDouble(Console.ReadLine());

                // Ввод второго числа от пользователя
                Console.Write("Введите второе число: ");
                double b = Convert.ToDouble(Console.ReadLine());

                // Ввод арифметической операции от пользователя
                Console.Write("Введите операцию (+ - * /): ");
                string op = Console.ReadLine();

                double result = 0;

                switch (op)
                {
                    case "+":
                        result = calc.Add(a, b);
                        break;
                    case "-":
                        result = calc.Sub(a, b);
                        break;
                    case "*":
                        result = calc.Mul(a, b);
                        break;
                    case "/":
                        result = calc.Div(a, b);
                        break;
                    default:
                        Console.Write("Ошибка: Неизвестная операция.");
                        return;
                }

                // Вывод результата
                Console.WriteLine($"Результат: {result}");
            }
            catch (Exception ex)
            {
                // Общая обработка ошибок (ввод не числа, деление на ноль, неизвестная операция)
                Console.WriteLine("Ошибка: " + ex.Message);
            }

            Console.ReadKey();
        }
    }
}
