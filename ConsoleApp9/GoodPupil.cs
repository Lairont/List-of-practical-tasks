using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class GoodPupil : Pupil
    {
        public GoodPupil(string lastName) : base(lastName) { }

        public override void Study()
        {
            Console.WriteLine($"{LastName}: Учится хорошо.");
        }

        public override void Read()
        {
            Console.WriteLine($"{LastName}: Читает с удовольствием.");
        }

        public override void Write()
        {
            Console.WriteLine($"{LastName}: Пишет старательно.");
        }

        public override void Relax()
        {
            Console.WriteLine($"{LastName}: Отдыхает в меру.");
        }
    }
}
