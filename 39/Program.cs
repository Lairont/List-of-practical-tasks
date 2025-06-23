using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Computer[] computers = new Computer[]
                {
                new Computer("ASUS ROG", 16, 500),
                new Computer("Lenovo ThinkPad", 8, 256),
                new Computer("HP Pavilion", 32, 1000),
                new Computer("Dell Inspiron", 4, 750)  // Ошибка: RAM < 2 — будет выброшено исключение
                };

                double totalPrice = 0;
                foreach (var comp in computers)
                {
                    comp.Print();
                    totalPrice += comp.Price;
                }

                Console.WriteLine($"\nОбщая стоимость всех моделей: {totalPrice} руб.");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Ошибка при создании компьютера: {ex.Message}");
            }
            Console.ReadKey();
        }
    }
}

