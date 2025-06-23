using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Список людей
            List<Person> peopleList = new List<Person>
        {
            new Person("Андрей", 25),
            new Person("Борис", 30),
            new Person("Глеб", 20),
            new Person("Виктор", 28)
        };

            // Множество людей
            HashSet<Person> peopleSet = new HashSet<Person>(peopleList);

            // Сортировка списка (использует CompareTo)
            peopleList.Sort();

            Console.WriteLine("Отсортированный список:");
            foreach (var p in peopleList)
                Console.WriteLine(p);

            Console.WriteLine("\nМножество (порядок не гарантируется):");
            foreach (var p in peopleSet)
                Console.WriteLine(p);

            Console.ReadKey();
        }
    }
}
