using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем объект счета
            Invoice invoice = new Invoice(12345, "Иванов Иван", "ООО Поставщик");

            // Задаем товар и количество
            invoice.SetOrder("Vivobook", 12);

            // Выводим информацию о счете
            invoice.PrintInvoice(7000);

            Console.ReadKey();
        }
    }
}
