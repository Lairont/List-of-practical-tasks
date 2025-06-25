using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {
            // Выводим все доступные должности
            Console.WriteLine("Доступные должности:");
            foreach (var post in Enum.GetNames(typeof(Post)))
            {
                Console.WriteLine(post);
            }

            // Ввод должности сотрудника
            Console.Write("Введите должность сотрудника: ");
            string inputPost = Console.ReadLine();

            // Проверяем, существует ли введённая должность
            Post workerPost;
            if (!Enum.TryParse(inputPost, out workerPost))
            {
                Console.WriteLine("Некорректная должность.");
                return;
            }

            // Ввод количества отработанных часов
            Console.Write("Введите количество отработанных часов: ");
            int hours;
            if (!int.TryParse(Console.ReadLine(), out hours))
            {
                Console.WriteLine("Некорректное количество часов.");
                return;
            }

            Accountant accountant = new Accountant();
            bool bonus = accountant.AskForBonus(workerPost, hours);

            // Вывод результата
            if (bonus)
                Console.WriteLine("Сотруднику положена премия.");
            else
                Console.WriteLine("Сотруднику не положена премия.");
        }
    }
}

