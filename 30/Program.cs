using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30
{
    internal class Program
    {
        static void Main(string[] args)
        { 
       Tovar[] tovary = new Tovar[]
        {
            new Book("Программирование", 500, 2),
            new Pen("Гелевая ручка", 20, 10),
            new Candy("Шоколадные", 300, 1.5)
        };

        Console.WriteLine("Расчёт стоимости товаров:\n");
        foreach (Tovar t in tovary)
        {
            t.Calc();
        }

        Console.ReadKey();
        }
    }
}
