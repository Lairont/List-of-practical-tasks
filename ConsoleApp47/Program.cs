using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp47
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Zakaz> zakazy = new List<Zakaz>();
            Console.WriteLine("Введите заказы. Для завершения введите Q в поле фамилии.\n");

            while (true)
            {
                Console.Write("Фамилия: ");
                string fam = Console.ReadLine();
                if (fam.Trim().ToUpper() == "Q") break;

                Console.Write("Количество мест: ");
                if (!int.TryParse(Console.ReadLine(), out int size))
                {
                    Console.WriteLine("Некорректный ввод количества. Повторите заказ.\n");
                    continue;
                }

                Console.Write("Комфорт (например: Стандарт, Люкс): ");
                string comfort = Console.ReadLine();

                Zakaz z = new Zakaz(fam, size, comfort);
                zakazy.Add(z);

                Console.WriteLine("Заказ добавлен!\n");
            }

            Console.WriteLine("\nСписок всех заказов:");
            foreach (var z in zakazy)
            {
                z.Show();
            }

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}