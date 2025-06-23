using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создаём массив товаров разных типов
            Tovar[] tovary = new Tovar[]
            {
            new Obuv("Кроссовки", 3500, 42, 2),
            new Odejda("Футболка", 1200, "Красный", "M", 3),
            new Posuda("Тарелка", 500, 0.5, 4)
            };

            Console.WriteLine("Информация о товарах:\n");

            foreach (var t in tovary)
            {
                t.Print();
            }
            Console.ReadKey();
        }
    }
}
