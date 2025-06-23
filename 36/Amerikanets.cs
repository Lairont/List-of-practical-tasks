using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36
{
    // Американец наследник
    class Amerikanets : Chelovek
    {
        public Amerikanets(string name) : base(name) { }

        public override void SkazatPrivetstvie()
        {
            Console.WriteLine($"Hi, {Name}!");
        }
    }
}
