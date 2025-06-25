using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаём массив клиентов
            Client[] clients = new Client[]
            {
                new Client("Иванов И.И.", "Автостраховка", 3000),
                new Client("Петров П.П.", "Медицинская страховка", 1500),
                new Client("Сидоров С.С.", "Автостраховка", 1800),
                new Client("Кузнецова А.А.", "Автостраховка", 2200),
                new Client("Смирнов В.В.", "Страховка жилья", 5000)
            };

            Console.WriteLine("Все клиенты:");
            foreach (var client in clients)
            {
                client.GetInfo();
            }

            Console.WriteLine("\nКлиенты, застраховавшие автомобиль на сумму более 2000 руб:");
            foreach (var client in clients)
            {
                if (client.InsuranceType == "Автостраховка" && client.InsuranceAmount > 2000)
                {
                    client.GetInfo();
                }
            }

            int autoInsuranceCount = 0;
            foreach (var client in clients)
            {
                if (client.InsuranceType == "Автостраховка")
                {
                    autoInsuranceCount++;
                }
            }

            Console.WriteLine($"\nКоличество клиентов с автостраховкой: {autoInsuranceCount}");

          
            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
