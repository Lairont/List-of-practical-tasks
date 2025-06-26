using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создание объектов разными способами
            Banknote b1 = new Banknote(); // по умолчанию
            Banknote b2 = new Banknote("Доллар", 10, 5); // с параметрами
            Banknote b3 = new Banknote("Евро", 50, 3);   // с параметрами

            // Установка свойств вручную
            b1.Name = "Рубль";
            b1.Denomination = 100;
            b1.Quantity = 10;

            // Вывод информации
            Console.WriteLine("Информация о купюрах:");
            b1.Show();
            b2.Show();
            b3.Show();

            Console.WriteLine("\nИзменение количества купюр:");
            b1.ChangeQuantity(-3); // уменьшить
            b2.ChangeQuantity(2);  // увеличить
            b1.Show();
            b2.Show();

            Console.WriteLine("\nПроверка, можно ли оплатить покупку:");
            int cost1 = 700;
            Console.WriteLine($"Можно ли оплатить {cost1} руб. с b1? " + (b1.CanPay(cost1) ? "Да" : "Нет"));

            int cost2 = 1000;
            Console.WriteLine($"Можно ли оплатить {cost2} руб. с b2? " + (b2.CanPay(cost2) ? "Да" : "Нет"));

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}