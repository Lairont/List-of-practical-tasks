using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38
{
    class Product
    {
        public string Name { get; set; }           // Наименование
        public string Manufacturer { get; set; }   // Производитель
        public double Price { get; set; }           // Цена
        public int ShelfLife { get; set; }          // Срок хранения (в днях)
        public int Quantity { get; set; }            // Количество

        public Product(string name, string manufacturer, double price, int shelfLife, int quantity)
        {
            Name = name;
            Manufacturer = manufacturer;
            Price = price;
            ShelfLife = shelfLife;
            Quantity = quantity;
        }

        // Метод для красивого вывода информации о товаре
        public void Print()
        {
            Console.WriteLine($"Наименование: {Name}, Производитель: {Manufacturer}, Цена: {Price}, Срок хранения: {ShelfLife} дней, Количество: {Quantity}");
        }
    }
}
