using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lessons_4
{
    class Program
    {
        static void Main()
        {
            //Создание екземпляра класса
            Document document = new Document("Контракт");

            document.Body = "Тело контракта...";
            document.Footer = "Директор: Иванов И.И.";

            document.Show();

            // Delay.
            Console.ReadKey();
        }
    }
}
