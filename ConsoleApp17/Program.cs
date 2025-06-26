using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаём список объектов, реализующих интерфейс ISwitchable
            List<ISwitchable> devices = new List<ISwitchable>();

            // Добавляем объекты в список
            devices.Add(new TVSet());
            devices.Add(new PersonalComputer());

            // Перебираем все устройства и вызываем их методы
            foreach (ISwitchable device in devices)
            {
                device.TurnOn();
                device.TurnOff();
                Console.WriteLine(); // Пустая строка для отделения вывода
            }

            Console.ReadKey(); // Ожидание нажатия клавиши перед закрытием программы
        }
    }
}

