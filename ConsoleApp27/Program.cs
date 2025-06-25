using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаём обобщённый список и добавляем элементы строчными буквами
            List<string> colors = new List<string>();
            colors.Add("red");
            colors.Add("blue");
            colors.Add("green");
            colors.Add("yellow");
            colors.Add("black");

            Console.WriteLine("1) Список после добавления элементов строчными буквами:");
            PrintList(colors);

            // Выводим содержимое коллекции на экран
            Console.WriteLine("\n2) Содержимое коллекции:");
            PrintList(colors);

            // Преобразуем все буквы элементов в прописные (заглавные)
            for (int i = 0; i < colors.Count; i++)
            {
                colors[i] = colors[i].ToUpper();
            }

            // Выводим содержимое коллекции на экран
            Console.WriteLine("\n4) Содержимое коллекции после преобразования в прописные буквы:");
            PrintList(colors);

            //  Определяем текущее количество элементов коллекции
            Console.WriteLine($"\n5) Количество элементов в коллекции: {colors.Count}");

            //  Добавляем в коллекцию новый элемент в конец списка
            colors.Add("PURPLE");
            Console.WriteLine("\n6) После добавления нового элемента в конец списка:");
            PrintList(colors);

            //  Выводим содержимое коллекции на экран
            Console.WriteLine("\n7) Содержимое коллекции после добавления в конец:");
            PrintList(colors);

            // Добавляем новый элемент в начало списка
            colors.Insert(0, "WHITE");
            Console.WriteLine("\n8) После добавления нового элемента в начало списка:");
            PrintList(colors);

            // Выводим содержимое коллекции на экран
            Console.WriteLine("\n9) Содержимое коллекции после добавления в начало:");
            PrintList(colors);

            // Удаляем третий элемент коллекции 
            if (colors.Count >= 3)
            {
                colors.RemoveAt(2);
                Console.WriteLine("\n10) После удаления третьего элемента коллекции:");
                PrintList(colors);
            }
            else
            {
                Console.WriteLine("\n10) В коллекции недостаточно элементов для удаления третьего элемента.");
            }

            // Выводим содержимое коллекции на экран
            Console.WriteLine("\n11) Содержимое коллекции после удаления третьего элемента:");
            PrintList(colors);

            // Располагаем элементы в обратном порядке
            colors.Reverse();
            Console.WriteLine("\n12) Содержимое коллекции после разворота:");
            PrintList(colors);

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }

        //  Метод для вывода содержимого списка
        static void PrintList(List<string> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
