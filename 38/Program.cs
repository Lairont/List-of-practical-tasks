using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создаём массив товаров
            Product[] products = new Product[]
            {
            new Product("Молоко", "Вкуснотеево", 80, 7, 10),
            new Product("Молоко", "Простоквашино", 75, 5, 8),
            new Product("Хлеб", "Булочная №1", 40, 3, 20),
            new Product("Сыр", "Ламбер", 300, 30, 5),
            new Product("Молоко", "Домик в деревне", 90, 10, 15)
            };

            // а) Список товаров по заданному наименованию
            Console.Write("Введите наименование товара для поиска: ");
            string searchName = Console.ReadLine();

            Console.WriteLine($"\nТовары с наименованием \"{searchName}\":");
            foreach (var p in products)
            {
                if (p.Name.Equals(searchName, StringComparison.OrdinalIgnoreCase))
                {
                    p.Print();
                }
            }

            // б) Список товаров по наименованию с ценой не выше указанной
            Console.Write("\nВведите максимальную цену для фильтра: ");
            if (!double.TryParse(Console.ReadLine(), out double maxPrice))
            {
                Console.WriteLine("Ошибка: введено не число");
                return;
            }

            Console.WriteLine($"\nТовары \"{searchName}\" с ценой не выше {maxPrice}:");
            foreach (var p in products)
            {
                if (p.Name.Equals(searchName, StringComparison.OrdinalIgnoreCase) && p.Price <= maxPrice)
                {
                    p.Print();
                }
            }

            // в) Список товаров со сроком хранения больше заданного
            Console.Write("\nВведите минимальный срок хранения (в днях): ");
            if (!int.TryParse(Console.ReadLine(), out int minShelfLife))
            {
                Console.WriteLine("Ошибка: введено не число");
                return;
            }

            Console.WriteLine($"\nТовары со сроком хранения больше {minShelfLife} дней:");
            foreach (var p in products)
            {
                if (p.ShelfLife > minShelfLife)
                {
                    p.Print();
                }
            }
            Console.ReadKey();
        }
    }
}
