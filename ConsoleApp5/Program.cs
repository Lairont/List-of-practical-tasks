using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter(3.20, 3.50, 0.034);

            // Выводим меню для пользователя
            Console.WriteLine("Выберите операцию:");
            Console.WriteLine("1 - Конвертация из BYN в валюту");
            Console.WriteLine("2 - Конвертация из валюты в BYN");
            string choice = Console.ReadLine(); // Читаем выбор пользователя

            if (choice == "1")
            {
                // Запрос суммы в BYN
                Console.Write("Введите сумму в BYN: ");
                double amountBYN = Convert.ToDouble(Console.ReadLine());

                // Запрос валюты для конвертации
                Console.Write("Введите валюту (USD, EUR, RUB): ");
                string currency = Console.ReadLine();

                try
                {
                    // Выполняем конвертацию
                    double result = converter.ConvertFromBYN(currency, amountBYN);
                    Console.WriteLine($"Результат: {result} {currency}");
                }
                catch (ArgumentException ex)
                {
                    // Обрабатываем ошибку неверного ввода валюты
                    Console.WriteLine(ex.Message);
                }
            }
            else if (choice == "2")
            {
                // Запрос валюты
                Console.Write("Введите валюту (USD, EUR, RUB): ");
                string currency = Console.ReadLine();

                // Запрос суммы в выбранной валюте
                Console.Write($"Введите сумму в {currency}: ");
                double amount = Convert.ToDouble(Console.ReadLine());

                try
                {
                    // Конвертация в BYN
                    double result = converter.ConvertToBYN(currency, amount);
                    Console.WriteLine($"Результат: {result} BYN");
                }
                catch (ArgumentException ex)
                {
                    // Обрабатываем ошибку неверного ввода валюты
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                // Сообщаем о неверном выборе операции
                Console.WriteLine("Неверный выбор операции.");
            }

            Console.WriteLine("Нажмите любую клавишу для выхода...");
           
            
            Console.ReadKey(); 
        }
    }
}

