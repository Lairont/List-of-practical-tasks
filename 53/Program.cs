using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _53
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tovar[] tovary = new Tovar[]
            {
            new Obuv("Кроссовки", 4500, 42),
            new Odejda("Куртка", 8000, "Синий"),
            new Posuda("Тарелка", 250, 0.5, 6)
            };

            foreach (Tovar t in tovary)
            {
                t.Print();
            }
            Console.ReadKey();
        }
    }
}

