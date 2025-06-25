using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    class Tovar
    {
        private string name;
        private int price;
        private int kvo;

        // Свойство для названия
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // Свойство для цены с ограничением от 1 до 20
        public int Price
        {
            get { return price; }
            set
            {
                if (value >= 1 && value <= 20)
                    price = value;
                else
                    price = 1; // значение по умолчанию
            }
        }

        // Свойство для количества с ограничением от 0 до 10
        public int Kvo
        {
            get { return kvo; }
            set
            {
                if (value >= 0 && value <= 10)
                    kvo = value;
                else
                    kvo = 0; // значение по умолчанию
            }
        }

        // Конструктор
        public Tovar(string name, int price, int kvo)
        {
            Name = name;
            Price = price;
            Kvo = kvo;
        }

        // Метод для подсчета стоимости конкретного товара
        public int GetTotalCost()
        {
            return Price * Kvo;
        }

        // Метод для вывода информации о товаре
        public void PrintInfo()
        {
            Console.WriteLine($"Товар: {Name}, Цена: {Price}, Кол-во: {Kvo}, Сумма: {GetTotalCost()} руб.");
        }
    }
}
