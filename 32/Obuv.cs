using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32
{
    class Obuv : Tovar
    {
        public int Size { get; set; }      // Размер обуви
        public int Quantity { get; set; }  // Количество пар

        public Obuv(string name, double price, int size, int quantity)
            : base(name, price)
        {
            Size = size;
            Quantity = quantity;
        }

        // Расчёт стоимости с учётом количества
        public override double CalcSum()
        {
            return Price * Quantity;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Размер: {Size}");
            Console.WriteLine($"Количество: {Quantity}");
            Console.WriteLine($"Итоговая стоимость: {CalcSum()}");
            Console.WriteLine();
        }
    }
}
