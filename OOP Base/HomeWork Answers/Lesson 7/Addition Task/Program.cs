using System;

namespace Lessons8
{
    class Program
    {
        static void Main()
        {
            Notebook notebook1 = new Notebook(); //Создание екземпляра класса Notebook
            notebook1.Show(); //отображение полей класса

            Notebook notebook2 = new Notebook("TT-45", "DELL", 570.99); //Создание экземпляра класса с помощью пользовательского конструктора и передача в конструктор 3 параметра
            notebook2.Show();

            Notebook notebook3 = new Notebook("RR-34"); //Создание экземпляра класса с помощью пользовательского конструктора и передача в конструктор 1 параметр
            notebook3.Show();

            // Delay.
            Console.ReadKey();
        }
    }
}
