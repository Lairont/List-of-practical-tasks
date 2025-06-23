using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _50
{
    class GoodPupil : Pupil
    {
        public GoodPupil(string lastName) : base(lastName) { }

        public override void Study() => Console.WriteLine($"{LastName}: Учится хорошо");
        public override void Read() => Console.WriteLine($"{LastName}: Читает достаточно быстро");
        public override void Write() => Console.WriteLine($"{LastName}: Пишет без ошибок");
        public override void Relax() => Console.WriteLine($"{LastName}: Умеет совмещать отдых и учёбу");
    }

}
