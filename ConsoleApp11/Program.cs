using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ключ доступа (pro / exp): ");
            string key = Console.ReadLine();

            DocumentWorker worker;

            if (key == "pro")
            {
                worker = new ProDocumentWorker();
            }
            else if (key == "exp")
            {
                worker = new ExpertDocumentWorker();
            }
            else
            {
                worker = new DocumentWorker();
            }

            // Демонстрация работы методов
            worker.OpenDocument();
            worker.EditDocument();
            worker.SaveDocument();

            Console.ReadKey();
        }
    }
}

