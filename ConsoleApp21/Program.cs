using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Program
    {
        // Метод для изменения значения в классе
        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "изменено";
        }

        // Метод для изменения значения в структуре
        static void StructTaker(MyStruct myStruct)
        {
            myStruct.change = "изменено";
        }

        static void Main(string[] args)
        {
            // Создаём объект класса
            MyClass classObj = new MyClass();
            classObj.change = "не изменено";

            // Создаём объект структуры
            MyStruct structObj = new MyStruct();
            structObj.change = "не изменено";

            // Вызываем методы изменения
            ClassTaker(classObj);
            StructTaker(structObj);

            // Выводим результаты
            Console.WriteLine("Значение поля класса: {0}", classObj.change);
            Console.WriteLine("Значение поля структуры: {0}", structObj.change);

            Console.ReadKey();
        }
    }
}

