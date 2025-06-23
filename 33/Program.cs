using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 5. Создание объекта и вызов метода
            DerivedClass dClass = new DerivedClass();
            dClass.Method();

            Console.ReadKey();
        }
    }
}
