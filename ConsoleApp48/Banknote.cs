using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48
{
    class Banknote
    {
        // Поля
        private string name;
        private int denomination;
        private int quantity;

        // Свойства с проверкой
        public string Name
        {
            get => name;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    name = value;
                else
                    throw new ArgumentException("Название не может быть пустым.");
            }
        }

        public int Denomination
        {
            get => denomination;
            set
            {
                if (value > 0)
                    denomination = value;
                else
                    throw new ArgumentException("Номинал должен быть положительным.");
            }
        }

        public int Quantity
        {
            get => quantity;
            set
            {
                if (value >= 0)
                    quantity = value;
                else
                    throw new ArgumentException("Количество не может быть отрицательным.");
            }
        }

        // Конструктор по умолчанию
        public Banknote()
        {
            Name = "Без названия";
            Denomination = 1;
            Quantity = 0;
        }

        // Конструктор с параметрами
        public Banknote(string name, int denomination, int quantity)
        {
            Name = name;
            Denomination = denomination;
            Quantity = quantity;
        }

        // Метод: вывод информации
        public void Show()
        {
            Console.WriteLine($"Купюра: {Name}, Номинал: {Denomination}, Количество: {Quantity}");
        }

        // Метод: изменить количество
        public void ChangeQuantity(int change)
        {
            if (Quantity + change >= 0)
                Quantity += change;
            else
                Console.WriteLine("Ошибка: количество не может быть отрицательным.");
        }

        // Метод: проверка, достаточно ли средств
        public bool CanPay(int cost)
        {
            return (Denomination * Quantity) >= cost;
        }
    }
}
