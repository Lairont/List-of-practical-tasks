using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _53
{
    // Посуда
    class Posuda : Tovar
    {
        public double Weight { get; set; }
        public int Quantity { get; set; }

        public Posuda(string name, double price, double weight, int quantity)
            : base(name, price)
        {
            Weight = weight;
            Quantity = quantity;
        }

        public override double CalcSum()
        {
            return Price * Quantity; // Общая цена за все
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Вес одного изделия: {Weight} кг");
            Console.WriteLine($"Количество: {Quantity}");
            Console.WriteLine($"Итоговая стоимость: {CalcSum()} руб.\n");
        }
    }
}
