using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39
{
    class Computer
    {
        private string model;
        private int ram;  // Гбайт
        private int hdd;  // Гбайт

        // Свойство Model — обычное, без ограничений
        public string Model
        {
            get => model;
            set => model = value;
        }

        // Свойство RAM с ограничениями (2 - 32 Гбайт)
        public int Ram
        {
            get => ram;
            set
            {
                if (value < 2 || value > 32)
                    throw new ArgumentOutOfRangeException("Ram", "Объем ОЗУ должен быть от 2 до 32 Гбайт.");
                ram = value;
            }
        }

        // Свойство HDD с ограничениями (200 - 2000 Гбайт)
        public int Hdd
        {
            get => hdd;
            set
            {
                if (value < 200 || value > 2000)
                    throw new ArgumentOutOfRangeException("Hdd", "Объем жесткого диска должен быть от 200 до 2000 Гбайт.");
                hdd = value;
            }
        }

        // Свойство Price — только для чтения
        public double Price => CalculatePrice();

        // Конструктор с параметрами
        public Computer(string model, int ram, int hdd)
        {
            Model = model;
            Ram = ram;
            Hdd = hdd;
        }

        // Метод вычисления стоимости модели (пример формулы)
        private double CalculatePrice()
        {
            // Примерная формула:
            // Цена = 10000 + 2000 за каждый Гб RAM + 10 за каждый Гб HDD
            return 10000 + ram * 2000 + hdd * 10;
        }

        public void Print()
        {
            Console.WriteLine($"Модель: {Model}, RAM: {Ram} Гб, HDD: {Hdd} Гб, Цена: {Price} руб.");
        }
    }
}
