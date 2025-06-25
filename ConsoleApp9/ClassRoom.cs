using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class ClassRoom
    {
        private Pupil[] pupils = new Pupil[4];

        public ClassRoom(params Pupil[] pupils)
        {
            for (int i = 0; i < this.pupils.Length; i++)
            {
                if (i < pupils.Length)
                {
                    this.pupils[i] = pupils[i];
                }
                else
                {
                    this.pupils[i] = new GoodPupil("По умолчанию");
                }
            }
        }

        public void ShowAll()
        {
            foreach (Pupil pupil in pupils)
            {
                pupil.Study();
                pupil.Read();
                pupil.Write();
                pupil.Relax();
                Console.WriteLine();
            }
        }
    }
}
