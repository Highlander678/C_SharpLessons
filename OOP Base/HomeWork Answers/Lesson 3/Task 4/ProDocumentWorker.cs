using System;

namespace Task_4
{
    class ProDocumentWorker : DocumentWorker
    {
        public override void EditDocument() //Модификатор override требуется для расширения изменений виртуальной реализации унаследованного метода.
        {
            Console.WriteLine("Документ отредактирован");
        }
        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Эксперт");
        }
    }
}
