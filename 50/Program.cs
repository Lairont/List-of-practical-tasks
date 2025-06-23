using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _50
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создание учеников
            Pupil p1 = new ExcellentPupil("Иванов");
            Pupil p2 = new GoodPupil("Петров");
            Pupil p3 = new BadPupil("Сидоров");

            // Создание класса с 3 учениками (4-й добавится автоматически)
            ClassRoom classRoom = new ClassRoom(p1, p2, p3);

            // Демонстрация всех умений
            classRoom.ShowAll();
            Console.ReadKey();
        }
    }
}
