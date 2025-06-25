using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    class Program
    {
        static void Main(string[] args)
        {
            // Список товаров
            List<Tovar> order = new List<Tovar>
            {
                new Tovar("Карандаш", 5, 3),
                new Tovar("Ручка", 10, 2),
                new Tovar("Тетрадь", 15, 5),
                new Tovar("Стерка", 100, -1) // проверка ограничений
            };

            Console.WriteLine("Список заказанных товаров:\n");

            int totalOrderCost = 0;

            foreach (Tovar t in order)
            {
                t.PrintInfo();
                totalOrderCost += t.GetTotalCost();
            }

            Console.WriteLine($"\nОбщая стоимость заказа: {totalOrderCost} руб.");

            Console.ReadKey();
        }
    }
}
