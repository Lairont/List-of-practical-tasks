using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class User
    {
        // Поля и свойства
        public string Login { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public DateTime DateOfFilling { get; } // Только для чтения — инициализируется при создании объекта

        // Конструктор
        public User(string login, string firstName, string lastName, int age)
        {
            Login = login;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            DateOfFilling = DateTime.Now; // Дата заполнения анкеты фиксируется при создании
        }

        // Метод для вывода информации
        public void PrintInfo()
        {
            Console.WriteLine("Информация о пользователе:");
            Console.WriteLine($"Логин: {Login}");
            Console.WriteLine($"Имя: {FirstName}");
            Console.WriteLine($"Фамилия: {LastName}");
            Console.WriteLine($"Возраст: {Age}");
            Console.WriteLine($"Дата заполнения анкеты: {DateOfFilling}");
        }
    }
}
