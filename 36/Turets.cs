using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36
{
    // Турок наследник (пример с Merhaba)
    class Turets : Chelovek
    {
        public Turets(string name) : base(name) { }

        public override void SkazatPrivetstvie()
        {
            Console.WriteLine($"Merhaba, {Name}!");
        }
    }
}
