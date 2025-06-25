using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class MyClass : InterfaceC
    {
        public void ShowInterfaceA()
        {
            Console.WriteLine("ShowInterfaceA() is completed.");
        }

        public void ShowInterfaceB()
        {
            Console.WriteLine("ShowInterfaceB() is completed.");
        }

        public void ShowInterfaceC()
        {
            Console.WriteLine("ShowInterfaceC() is completed.");
        }
    }
}
