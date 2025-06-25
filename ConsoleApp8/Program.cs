using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем объект пользователя
            User user = new User("user12345", "Иван", "Петрович", 18);

            // Выводим информацию
            user.PrintInfo();

            Console.ReadKey();
        }
    }
}
