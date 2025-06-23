using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30
{
    class Pen : Tovar
    {
        private int kvo;

        public Pen(string name, double price, int kvo) : base(name, price)
        {
            this.kvo = kvo;
        }

        public override void Calc()
        {
            double total = price * kvo;
            Console.WriteLine($"Ручка: {name}, Количество: {kvo}, Цена за штуку: {price}, Итог: {total}");
        }
    }
}
