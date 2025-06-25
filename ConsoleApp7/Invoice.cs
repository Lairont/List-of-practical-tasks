using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Invoice
    {
        // Поля, которые инициализируются один раз через конструктор
        public int Account { get; }
        public string Customer { get; }
        public string Provider { get; }

        // Закрытые поля
        private string article;
        private int quantity;

        // Конструктор
        public Invoice(int account, string customer, string provider)
        {
            Account = account;
            Customer = customer;
            Provider = provider;
        }

        // Метод для установки товара и количества
        public void SetOrder(string article, int quantity)
        {
            this.article = article;
            this.quantity = quantity;
        }

        // Метод для расчета стоимости
        public double CalculateTotal(double pricePerUnit, bool includeVAT)
        {
            double total = pricePerUnit * quantity;
            if (includeVAT)
            {
                total *= 1.2; // Добавляем 20% НДС
            }
            return total;
        }

        // Метод для вывода информации
        public void PrintInvoice(double pricePerUnit)
        {
            Console.WriteLine($"Счет: {Account}");
            Console.WriteLine($"Клиент: {Customer}");
            Console.WriteLine($"Поставщик: {Provider}");
            Console.WriteLine($"Товар: {article}");
            Console.WriteLine($"Количество: {quantity}");
            Console.WriteLine($"Цена за единицу: {pricePerUnit}");

            Console.WriteLine($"Итого без НДС: {CalculateTotal(pricePerUnit, false)}");
            Console.WriteLine($"Итого с НДС: {CalculateTotal(pricePerUnit, true)}");
        }
    }
}