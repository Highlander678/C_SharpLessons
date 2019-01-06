using System;

namespace Task_3
{
    class Title
    {
        //Поле класса предназначенное только для чтения.
        readonly string title;

        public Title(string title)
        {
            //Присвоение полю title класса Title значения аргумента переданного в конструктор
            this.title = title;
        }

        //Метод предназначен для отображения значения title
        public void Show()
        {
            //Задает цвет текста консоли.
            Console.ForegroundColor = ConsoleColor.Red;
            //Запись в стандартный выходной поток.
            Console.WriteLine("Title: " + title);
        }
    }
}
