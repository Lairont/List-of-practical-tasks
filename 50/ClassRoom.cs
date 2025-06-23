using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _50
{
    class ClassRoom
    {
        private Pupil[] pupils = new Pupil[3];

        // Конструктор с переменным числом параметров
        public ClassRoom(params Pupil[] inputPupils)
        {
            for (int i = 0; i < pupils.Length; i++)
            {
                if (i < inputPupils.Length)
                    pupils[i] = inputPupils[i];
                else
                    pupils[i] = new BadPupil($"Ученик_{i + 1}"); // по умолчанию плохой ученик
            }
        }
        public void ShowAll()
        {
            foreach (var p in pupils)
            {
                Console.WriteLine($"\nУченик {p.LastName}:");
                p.Study();
                p.Read();
                p.Write();
                p.Relax();
            }
        }
    }
}
