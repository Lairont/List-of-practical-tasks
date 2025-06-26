using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp47
{
    class Zakaz
    {
        // Поля
        private string fam;
        private int size;
        private string comfort;

        // Конструкторы

        // 1. Без параметров
        public Zakaz()
        {
            fam = "Неизвестно";
            size = 1;
            comfort = "Стандарт";
        }

        // 2. Один параметр (фамилия)
        public Zakaz(string fam)
        {
            this.fam = fam;
            size = 1;
            comfort = "Стандарт";
        }

        // 3. Два параметра (фамилия, размер)
        public Zakaz(string fam, int size)
        {
            this.fam = fam;
            this.size = size;
            comfort = "Стандарт";
        }

        // 4. Все параметры
        public Zakaz(string fam, int size, string comfort)
        {
            this.fam = fam;
            this.size = size;
            this.comfort = comfort;
        }

        // Метод вывода информации
        public void Show()
        {
            Console.WriteLine($"Фамилия: {fam}, Мест: {size}, Комфорт: {comfort}");
        }
    }
}
