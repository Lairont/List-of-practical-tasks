using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Exploring interface Example-3***");
            Console.WriteLine("***Concept of multiple inheritance through interface***");
            Console.WriteLine();

            MyClass myClassOb = new MyClass(); // Создаём объект класса MyClass

            // Вызываем все методы
            myClassOb.ShowInterfaceA();
            myClassOb.ShowInterfaceB();
            myClassOb.ShowInterfaceC();

            Console.ReadKey(); 
        }
    }
}

