using System;
using System.Collections.Generic;

namespace Task_1
{
    abstract class BaseClass
    {
        protected abstract void Read();
        protected abstract void Write();

        public void ReadWrite()
        {
            Read();
            Write();
        }
    }

    class DerivedClassTXT : BaseClass
    {
        protected override void Read()
        {
            Console.WriteLine("Чтение из файла TXT");
        }

        protected override void Write()
        {
            Console.WriteLine("Запись в файл TXT");
        }
    }

    class DerivedClassXML : BaseClass
    {
        protected override void Read()
        {
            Console.WriteLine("Чтение из файла XML");
        }

        protected override void Write()
        {
            Console.WriteLine("Запись в файл XML");
        }
    }

    class Program
    {
        static void Main()
        {
            List<BaseClass> collection = new List<BaseClass> { new DerivedClassTXT(), new DerivedClassXML() };

            foreach (var item in collection)
            {
                item.ReadWrite();
            }
        }
    }
}
