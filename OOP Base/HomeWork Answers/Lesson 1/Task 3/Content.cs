using System;

namespace Task_3
{
    class Content
    {
        readonly string content;

        public Content(string content)
        {
            //Присвоение полю content класса Content значения аргумента переданного в конструктор
            this.content = content;
        }

        public void Show()
        {
            //Задает цвет текста консоли.
            Console.ForegroundColor = ConsoleColor.White;
            //Запись в стандартный выходной поток.
            Console.WriteLine("Content: " + content);
        }
    }
}
