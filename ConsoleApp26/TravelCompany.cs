using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class TravelCompany
    {
        public string Name { get; set; }
        public int YearEstablished { get; set; }
        public string INN { get; set; }
        public double Profit { get; set; }

        // Конструктор
        public TravelCompany(string name, int year, string inn, double profit)
        {
            Name = name;
            YearEstablished = year;
            INN = inn;
            Profit = profit;
        }

        // Метод для вывода информации
        public void PrintInfo()
        {
            Console.WriteLine($"Название: {Name}, Год основания: {YearEstablished}, ИНН: {INN}, Прибыль: {Profit} руб.");
        }
    }
}
