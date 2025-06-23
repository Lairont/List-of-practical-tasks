using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 7. Создание объекта и вызов всех методов
            DerivedClass dClass = new DerivedClass();

            dClass.Method1();
            dClass.Method2();
            dClass.Method3();

            Console.ReadKey();
        }
    }
}
