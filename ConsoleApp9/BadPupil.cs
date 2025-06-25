using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class BadPupil : Pupil
    {
        public BadPupil(string lastName) : base(lastName) { }

        public override void Study()
        {
            Console.WriteLine($"{LastName}: Учится плохо.");
        }

        public override void Read()
        {
            Console.WriteLine($"{LastName}: Читает нехотя.");
        }

        public override void Write()
        {
            Console.WriteLine($"{LastName}: Пишет небрежно.");
        }

        public override void Relax()
        {
            Console.WriteLine($"{LastName}: Часто отдыхает.");
        }
    }
}
