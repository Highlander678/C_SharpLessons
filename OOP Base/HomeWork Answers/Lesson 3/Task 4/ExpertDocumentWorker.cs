using System;

namespace Task_4
{
    class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void SaveDocument() //Модификатор override требуется для расширения изменений виртуальной реализации унаследованного метода.
        {
            Console.WriteLine("Документ сохранен в других форматах");
        }
    }
}
