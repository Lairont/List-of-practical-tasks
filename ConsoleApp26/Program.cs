using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
            // Коллекция фирм
            List<TravelCompany> companies = new List<TravelCompany>
            {
                new TravelCompany("Солнышко-Тур", 2005, "1234567890", 500000),
                new TravelCompany("Мир Путешествий", 2010, "9876543210", 750000),
                new TravelCompany("Глобал-Тревел", 2000, "1122334455", 0),
                new TravelCompany("Отдых и Ко", 2015, "9988776655", 920000)
            };

            // Вывод всех фирм
            Console.WriteLine("Список туристических фирм города:\n");
            foreach (var c in companies)
            {
                c.PrintInfo();
            }

            // Поиск ИНН и прибыли фирмы
            Console.Write("\nВведите название фирмы для поиска: ");
            string searchName = Console.ReadLine();
            var found = companies.FirstOrDefault(c => c.Name.Equals(searchName, StringComparison.OrdinalIgnoreCase));
            if (found != null)
            {
                Console.WriteLine($"\nИНН: {found.INN}, Прибыль: {found.Profit} руб.");
            }
            else
            {
                Console.WriteLine("Фирма не найдена.");
            }

            //  Прибыль всех фирм вместе взятых
            double totalProfit = companies.Sum(c => c.Profit);
            Console.WriteLine($"\nСуммарная прибыль всех фирм: {totalProfit} руб.");

            //  Фирма с наибольшей прибылью
            var top = companies.OrderByDescending(c => c.Profit).First();
            Console.WriteLine($"\nФирма с наибольшей прибылью: {top.Name}, прибыль: {top.Profit} руб.");

            //  Удаление обанкротившейся фирмы (прибыль равна 0)
            companies.RemoveAll(c => c.Profit == 0);
            Console.WriteLine("\nОбновлённый список фирм после удаления обанкротившихся:");
            foreach (var c in companies)
            {
                c.PrintInfo();
            }

            //  Добавление фирмы
            Console.WriteLine("\nВведите данные новой фирмы:");
            Console.Write("Название: ");
            string newName = Console.ReadLine();
            Console.Write("Год основания: ");
            int newYear = int.Parse(Console.ReadLine());
            Console.Write("ИНН: ");
            string newINN = Console.ReadLine();
            Console.Write("Прибыль: ");
            double newProfit = double.Parse(Console.ReadLine());

            companies.Add(new TravelCompany(newName, newYear, newINN, newProfit));

            Console.WriteLine("\nСписок фирм после добавления новой:");
            foreach (var c in companies)
            {
                c.PrintInfo();
            }

      
            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
