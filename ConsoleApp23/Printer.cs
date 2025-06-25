using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    enum MyColor
    {
        Black = 0,
        Blue = 1,
        Green = 2,
        Cyan = 3,
        Red = 4,
        Magenta = 5,
        Yellow = 6,
        White = 7
    }

    class Printer
    {
        public static void Print(string stroka, int color)
        {
            if (Enum.IsDefined(typeof(MyColor), color))
            {
                Console.ForegroundColor = (ConsoleColor)color;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.WriteLine(stroka);
            Console.ResetColor();
        }
    }
}
