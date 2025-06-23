using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _30
{
    class Book : Tovar
    {
        private int kvo;

        public Book(string name, double price, int kvo) : base(name, price)
        {
            this.kvo = kvo;
        }

        public override void Calc()
        {
            double total = price * kvo;
            Console.WriteLine($"Книга: {name}, Количество: {kvo}, Цена за штуку: {price}, Итог: {total}");
        }
    }
}
