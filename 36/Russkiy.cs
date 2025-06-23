using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36
{
    // Русский наследник
    class Russkiy : Chelovek
    {
        public Russkiy(string name) : base(name) { }

        public override void SkazatPrivetstvie()
        {
            Console.WriteLine($"Привет, {Name}!");
        }
    }
}
