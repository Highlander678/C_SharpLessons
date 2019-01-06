using System;

namespace Task_2
{
    class Redactor
    {
        AbstractHandler handler;

        public void ChooseDocument(string fileName)
        {
            string format = fileName.Substring(fileName.Length - 4);

            switch (format.ToLower())
            {
                case ".txt": handler = new TXTHandler(fileName);
                    break;
                case ".doc": handler = new DOCHandler(fileName);
                    break;
                case ".xml": handler = new XMLHandler(fileName);
                    break;
                default: Console.WriteLine("Неопознаный формат");
                    break;
            }
        }

        public void Open()
        {
            handler.Open();
        }

        public void Craete()
        {
            handler.Create();
        }

        public void Change()
        {
            handler.Chenge();
        }

        public void Save()
        {
            handler.Save();
        }
    }
}
