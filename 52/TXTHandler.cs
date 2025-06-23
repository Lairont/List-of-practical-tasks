using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _52
{
    // Обработчик TXT
    class TXTHandler : AbstractHandler
    {
        public override void Open() => Console.WriteLine("Открытие документа формата - DOC");
        public override void Create() => Console.WriteLine("Создание документа формата - DOC");
        public override void Change() => Console.WriteLine("Редактирование документа формата - DOC");
        public override void Save() => Console.WriteLine("Сохранение документа формата - DOC");
    }
}
