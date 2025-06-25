using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class TXTHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Открытие TXT-документа.");
        }

        public override void Create()
        {
            Console.WriteLine("Создание TXT-документа.");
        }

        public override void Change()
        {
            Console.WriteLine("Редактирование TXT-документа.");
        }

        public override void Save()
        {
            Console.WriteLine("Сохранение TXT-документа.");
        }
    }
}
