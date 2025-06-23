using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _52
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Введите формат документа (DOC, TXT, XML или QUIT для выхода): ");
                string input = Console.ReadLine().Trim().ToUpper();

                if (input == "QUIT")
                    break;

                AbstractHandler handler = null;

                if (input == "XML")
                    handler = new XMLHandler();
                else if (input == "TXT")
                    handler = new TXTHandler();
                else if (input == "DOC")
                    handler = new DOCHandler();

                if (handler == null)
                {
                    Console.WriteLine("Неверный формат! Попробуйте снова.\n");
                    continue;
                }

                handler.Open();
                handler.Create();
                handler.Change();
                handler.Save();
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

