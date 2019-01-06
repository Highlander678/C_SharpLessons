using System;

namespace Task_4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите ключ");
            string key = Console.ReadLine();
            DocumentWorker doc = null; //Создание екземпляра класса DocumentWorker

            switch (key)
            {
                case "prof": doc = new ProDocumentWorker(); //Приведение экземпляра производного класса к базовому типу UpCast.
                    break;
                case "expert": doc = new ExpertDocumentWorker();
                    break;
                default: Console.WriteLine("Ключ неверен");
                    doc = new DocumentWorker();
                    break;
            }

            doc.OpenDocument(); //вызов метода OpenDocument на экземпляре doc класса 
            doc.EditDocument();
            doc.SaveDocument();

            Console.ReadKey();
        }

    }
}
