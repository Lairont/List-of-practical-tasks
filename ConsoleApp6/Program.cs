using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите фамилию сотрудника: ");
            string lastName = Console.ReadLine();

            Console.Write("Введите имя сотрудника: ");
            string firstName = Console.ReadLine();

            Employee employee = new Employee(lastName, firstName);

            Console.Write("Введите должность сотрудника (менеджер, инженер, директор): ");
            string position = Console.ReadLine();

            Console.Write("Введите стаж (в годах): ");
            int experience = int.Parse(Console.ReadLine());

            employee.SetPositionAndExperience(position, experience);

            Console.WriteLine();
            employee.PrintInfo();

            Console.ReadKey();
        }
    }
}

