using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32
{
    abstract class Tovar
    {
        public string Name { get; set; }       // Название товара
        public double Price { get; set; }      // Цена за единицу

        public Tovar(string name, double price)
        {
            Name = name;
            Price = price;
        }

        // Абстрактный метод для расчёта итоговой стоимости
        public abstract double CalcSum();

        // Метод для вывода информации о товаре
        public virtual void Print()
        {
            Console.WriteLine($"Название: {Name}");
            Console.WriteLine($"Цена за единицу: {Price}");
        }
    }
}
