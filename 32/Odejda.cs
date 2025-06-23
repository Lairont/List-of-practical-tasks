using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32
{
    class Odejda : Tovar
    {
        public string Color { get; set; }   // Цвет одежды
        public string Size { get; set; }    // Размер (S, M, L и т.д.)
        public int Quantity { get; set; }   // Количество

        public Odejda(string name, double price, string color, string size, int quantity)
            : base(name, price)
        {
            Color = color;
            Size = size;
            Quantity = quantity;
        }

        public override double CalcSum()
        {
            return Price * Quantity;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Цвет: {Color}");
            Console.WriteLine($"Размер: {Size}");
            Console.WriteLine($"Количество: {Quantity}");
            Console.WriteLine($"Итоговая стоимость: {CalcSum()}");
            Console.WriteLine();
        }
    }
}
