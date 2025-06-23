using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36
{
    // Украинец наследник
    class Ukranets : Chelovek
    {
        public Ukranets(string name) : base(name) { }

        public override void SkazatPrivetstvie()
        {
            Console.WriteLine($"Привіт, {Name}!");
        }
    }
}
