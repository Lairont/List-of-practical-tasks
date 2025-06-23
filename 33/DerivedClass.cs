using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33
{
    class DerivedClass : IInterface
    {
        // 4. Реализация метода
        public void Method()
        {
            Console.WriteLine("Метод, реализованный в классе DerivedClass");
        }
    }
}
