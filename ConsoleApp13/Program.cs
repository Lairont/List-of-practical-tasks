using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите формат документа (xml, txt, doc): ");
            string format = Console.ReadLine().ToLower();

            AbstractHandler handler = null;

            switch (format)
            {
                case "xml":
                    handler = new XMLHandler();
                    break;
                case "txt":
                    handler = new TXTHandler();
                    break;
                case "doc":
                    handler = new DOCHandler();
                    break;
                default:
                    Console.WriteLine("Неизвестный формат документа.");
                    return;
            }

            // Вызов методов
            handler.Open();
            handler.Create();
            handler.Change();
            handler.Save();

            Console.ReadKey();
        }
    }
}

