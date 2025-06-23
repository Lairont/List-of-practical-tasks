using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _50
{
    class ExcellentPupil : Pupil
    {
        public ExcellentPupil(string lastName) : base(lastName) { }

        public override void Study() => Console.WriteLine($"{LastName}: Учится отлично");
        public override void Read() => Console.WriteLine($"{LastName}: Читает много и быстро");
        public override void Write() => Console.WriteLine($"{LastName}: Пишет грамотно и аккуратно");
        public override void Relax() => Console.WriteLine($"{LastName}: Отдыхает умеренно");
    }

}
