using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _52
{
    // Обработчик XML
    class XMLHandler : AbstractHandler
    {
        public override void Open() => Console.WriteLine("Открытие документа формата - XML");
        public override void Create() => Console.WriteLine("Создание документа формата - XML");
        public override void Change() => Console.WriteLine("Редактирование документа формата - XML");
        public override void Save() => Console.WriteLine("Сохранение документа формата - XML");
    }

}
