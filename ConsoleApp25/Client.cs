using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class Client
    {
        public string Name { get; set; }
        public string InsuranceType { get; set; }
        public double InsuranceAmount { get; set; }

        // Конструктор для инициализации полей
        public Client(string name, string insuranceType, double insuranceAmount)
        {
            Name = name;
            InsuranceType = insuranceType;
            InsuranceAmount = insuranceAmount;
        }

        // Метод для получения информации о клиенте
        public void GetInfo()
        {
            Console.WriteLine($"Имя клиента: {Name}, Вид страховки: {InsuranceType}, Сумма страховки: {InsuranceAmount} руб.");
        }
    }

}
