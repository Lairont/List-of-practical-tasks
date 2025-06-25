using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    class Tour
    {
        public void TourCalc()
        {
            Console.WriteLine("Тур: Минское море");
            Console.WriteLine("Стоимость: бесплатно");
        }

        // Один параметр - страна (1 день, 50 руб)
        public void TourCalc(string country)
        {
            Console.WriteLine($"Тур: {country}");
            Console.WriteLine("Количество дней: 1");
            Console.WriteLine("Стоимость: 50 руб.");
        }

        // Два параметра - страна и количество дней (50 * n)
        public void TourCalc(string country, int days)
        {
            int cost = 50 * days;
            Console.WriteLine($"Тур: {country}");
            Console.WriteLine($"Количество дней: {days}");
            Console.WriteLine($"Стоимость: {cost} руб.");
        }
    }
}
