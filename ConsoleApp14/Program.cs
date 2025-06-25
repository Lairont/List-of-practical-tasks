using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player(); // Создаём объект класса Player

            Console.WriteLine("Воспроизведение:");
            player.Play();                 // Вызываем метод Play напрямую
            ((IPlayable)player).Pause();   // Явный вызов Pause через приведение к IPlayable
            ((IPlayable)player).Stop();    // Явный вызов Stop через приведение к IPlayable

            Console.WriteLine(); // Пустая строка для разделения вывода

            Console.WriteLine("Запись:");
            player.Record();                // Вызываем метод Record напрямую
            ((IRecodable)player).Pause();   // Явный вызов Pause через приведение к IRecodable
            ((IRecodable)player).Stop();    // Явный вызов Stop через приведение к IRecodable

            Console.ReadKey(); 
        }
    }
}

