using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Triangle <T>
    {
        private T a;
        private T b;
        private T c;

        public T A { get => a; set => a = value; }
        public T B { get => b; set => b = value; }
        public T C { get => c; set => c = value; }
        public Triangle() { }
        public Triangle(T a, T b, T c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }
        public void Info()
        {
            Console.WriteLine($"a= {A}\nb= {B}\nc= {C}");
        }
    }
}
