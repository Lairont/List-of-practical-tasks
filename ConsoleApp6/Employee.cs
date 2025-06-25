using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Employee
    {
        private string lastName;
        private string firstName;
        private string position;
        private int experience; // стаж в годах

        public Employee(string lastName, string firstName)
        {
            this.lastName = lastName;
            this.firstName = firstName;
        }

        // Метод для установки должности и стажа
        public void SetPositionAndExperience(string position, int experience)
        {
            this.position = position;
            this.experience = experience;
        }

        // Метод для расчета оклада
        public double CalculateSalary()
        {
            double baseSalary = 0.0;

            // Устанавливаем базовую зарплату в зависимости от должности
            switch (position.ToLower())
            {
                case "менеджер":
                    baseSalary = 40000;
                    break;
                case "инженер":
                    baseSalary = 50000;
                    break;
                case "директор":
                    baseSalary = 80000;
                    break;
                default:
                    baseSalary = 30000;
                    break;
            }

            // Увеличение за каждый год стажа (например, 3% за каждый год)
            double salary = baseSalary + (baseSalary * 0.03 * experience);
            return salary;
        }

        // Метод для расчета налогового сбора (например, 13% от зарплаты)
        public double CalculateTax()
        {
            double salary = CalculateSalary();
            double tax = salary * 0.13;
            return tax;
        }

        // Метод для вывода информации о сотруднике
        public void PrintInfo()
        {
            double salary = CalculateSalary();
            double tax = CalculateTax();
            Console.WriteLine("Информация о сотруднике:");
            Console.WriteLine($"Фамилия: {lastName}");
            Console.WriteLine($"Имя: {firstName}");
            Console.WriteLine($"Должность: {position}");
            Console.WriteLine($"Оклад: {salary:F2} руб.");
            Console.WriteLine($"Налоговый сбор (13%): {tax:F2} руб.");
        }
    }
}
