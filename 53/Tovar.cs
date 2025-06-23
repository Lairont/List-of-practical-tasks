using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _53
{
    abstract class Tovar
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Tovar(string name, double price)
        {
            Name = name;
            Price = price;
        }
        // Абстрактный метод для расчета стоимости
        public abstract double CalcSum();

        // Обычный метод для вывода информации
        public virtual void Print()
        {
            Console.WriteLine($"Название: {Name}");
            Console.WriteLine($"Цена за единицу: {Price} руб.");
        }
    }
}

