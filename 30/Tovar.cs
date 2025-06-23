using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30
{
    internal class Tovar
    {
        public string name;
        public double price;

        public Tovar(string name, double price)
        {
            this.name = name;
            this.price = price;
        }

        public virtual void Calc()
        {
            Console.WriteLine($"Товар: {name}, Цена: {price} (базовый)");
        }
    }
}
