using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30
{
    class Candy : Tovar
    {
        private double ves; // вес в кг

        public Candy(string name, double price, double ves) : base(name, price)
        {
            this.ves = ves;
        }

        public override void Calc()
        {
            double total = price * ves;
            Console.WriteLine($"Конфеты: {name}, Вес: {ves} кг, Цена за кг: {price}, Итог: {total}");
        }
    }
}
