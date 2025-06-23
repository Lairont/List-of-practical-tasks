using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _50
{
    class BadPupil : Pupil
    {
        public BadPupil(string lastName) : base(lastName) { }

        public override void Study() => Console.WriteLine($"{LastName}: Учится плохо");
        public override void Read() => Console.WriteLine($"{LastName}: Читает неохотно");
        public override void Write() => Console.WriteLine($"{LastName}: Часто делает ошибки");
        public override void Relax() => Console.WriteLine($"{LastName}: Любит отдыхать больше, чем учиться");
    }

}
