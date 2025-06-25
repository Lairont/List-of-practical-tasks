using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class DOCHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Открытие DOC-документа.");
        }

        public override void Create()
        {
            Console.WriteLine("Создание DOC-документа.");
        }

        public override void Change()
        {
            Console.WriteLine("Редактирование DOC-документа.");
        }

        public override void Save()
        {
            Console.WriteLine("Сохранение DOC-документа.");
        }
    }

}
