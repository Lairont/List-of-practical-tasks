using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _53
{
    // Одежда
    class Odejda : Tovar
    {
        public string Color { get; set; }

        public Odejda(string name, double price, string color)
            : base(name, price)
        {
            Color = color;
        }

        public override double CalcSum()
        {
            return Price; // Цена за 1 единицу
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Цвет: {Color}");
            Console.WriteLine($"Итоговая стоимость: {CalcSum()} руб.\n");
        }
    }
}
