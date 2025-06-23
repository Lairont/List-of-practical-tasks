using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34
{
    class DerivedClass : IInterface3
    {
        // 6. Реализация всех трёх методов
        public void Method1()
        {
            Console.WriteLine("Метод Method1");
        }

        public void Method2()
        {
            Console.WriteLine("Метод Method2");
        }

        public void Method3()
        {
            Console.WriteLine("Метод Method3");
        }
    }
}
