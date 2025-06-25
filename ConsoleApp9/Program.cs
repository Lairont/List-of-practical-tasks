using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем учеников
            Pupil p1 = new ExcelentPupil("Иванов");
            Pupil p2 = new GoodPupil("Петров");
            Pupil p3 = new BadPupil("Сидоров");
            Pupil p4 = new ExcelentPupil("Смирнова");

            // Можно передать 2, 3 или 4 аргумента
            ClassRoom classRoom = new ClassRoom(p1, p2, p3);

            // Вывод информации
            classRoom.ShowAll();

            Console.ReadLine();
        }
    }
}

