using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32
{
    class Posuda : Tovar
    {
        public double Weight { get; set; }   // Вес посуды в кг
        public int Quantity { get; set; }    // Количество штук

        public Posuda(string name, double price, double weight, int quantity)
            : base(name, price)
        {
            Weight = weight;
            Quantity = quantity;
        }

        public override double CalcSum()
        {
            return Price * Quantity;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Вес (кг): {Weight}");
            Console.WriteLine($"Количество: {Quantity}");
            Console.WriteLine($"Итоговая стоимость: {CalcSum()}");
            Console.WriteLine();
        }
    }
}
