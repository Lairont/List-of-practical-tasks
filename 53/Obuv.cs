using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _53
{
    // Обувь
    class Obuv : Tovar
    {
        public int Size { get; set; }

        public Obuv(string name, double price, int size)
            : base(name, price)
        {
            Size = size;
        }

        public override double CalcSum()
        {
            return Price; // Цена за 1 пару
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Размер: {Size}");
            Console.WriteLine($"Итоговая стоимость: {CalcSum()} руб.\n");
        }
    }
}
