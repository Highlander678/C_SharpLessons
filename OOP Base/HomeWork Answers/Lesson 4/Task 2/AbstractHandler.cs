using System;

namespace Task_2
{
    abstract class AbstractHandler
    {
        protected string fileName;

        public AbstractHandler(string fileName)
        {
            this.fileName = fileName;
        }

        public void Open()
        {
            Console.WriteLine(fileName + " открыт");
        }

        public void Create()
        {
            Console.WriteLine(fileName + " создан");
        }

        public void Chenge()
        {
            Console.WriteLine(fileName + " отредактирован");
        }

        public abstract void Save();
    }

    class XMLHandler : AbstractHandler
    {
        public XMLHandler(string fileName)
            : base(fileName)
        {
        }

        public override void Save()
        {
            Console.WriteLine(fileName + " сохранен в формате XML");
        }
    }

    class TXTHandler : AbstractHandler
    {
        public TXTHandler(string fileName)
            : base(fileName)
        {
        }

        public override void Save()
        {
            Console.WriteLine(fileName + " сохранен в формате TXT");
        }
    }

    class DOCHandler : AbstractHandler
    {
        public DOCHandler(string fileName)
            : base(fileName)
        {
        }

        public override void Save()
        {
            Console.WriteLine(fileName + " сохранен в формате DOC");
        }
    }
}
