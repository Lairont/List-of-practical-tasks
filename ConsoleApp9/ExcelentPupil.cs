using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class ExcelentPupil : Pupil
    {
        public ExcelentPupil(string lastName) : base(lastName) { }

        public override void Study()
        {
            Console.WriteLine($"{LastName}: Отлично учится.");
        }

        public override void Read()
        {
            Console.WriteLine($"{LastName}: Читает много и быстро.");
        }

        public override void Write()
        {
            Console.WriteLine($"{LastName}: Пишет аккуратно и грамотно.");
        }

        public override void Relax()
        {
            Console.WriteLine($"{LastName}: Немного отдыхает.");
        }
    }
}
