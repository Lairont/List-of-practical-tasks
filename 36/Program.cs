using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создаём объекты разных национальностей
            Chelovek[] people = new Chelovek[]
            {
            new Russkiy("Алексей"),
            new Ukranets("Олег"),
            new Amerikanets("John"),
            new Turets("Ahmet")
            };

            // Вызываем приветствие для каждого
            foreach (var person in people)
            {
                person.SkazatPrivetstvie();
            }
            Console.ReadKey();
        }
    }
}
