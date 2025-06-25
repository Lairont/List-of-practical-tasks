using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем экземпляр класса Address
            Address myAddress = new Address();

            // Заполняем данные через свойства
            myAddress.Index = "101015";
            myAddress.Country = "Россия";
            myAddress.City = "Москва";
            myAddress.Street = "Тверская";
            myAddress.House = "15";
            myAddress.Apartment = "45";

            // Выводим данные
            Console.WriteLine("Почтовый адрес:");
            Console.WriteLine("Индекс: " + myAddress.Index);
            Console.WriteLine("Страна: " + myAddress.Country);
            Console.WriteLine("Город: " + myAddress.City);
            Console.WriteLine("Улица: " + myAddress.Street);
            Console.WriteLine("Дом: " + myAddress.House);
            Console.WriteLine("Квартира: " + myAddress.Apartment);

            Console.ReadKey();
        }
    }
}

