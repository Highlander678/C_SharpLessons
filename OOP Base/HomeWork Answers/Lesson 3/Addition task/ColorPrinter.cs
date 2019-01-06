using System;

namespace Lessons_3
{
    class ColorPrinter : Printer
    {
        //Пользовательский конструктор с вызовом конструктора базового класса с помощью ключевого слова base.
        public ColorPrinter(ConsoleColor color)
            : base(color)
        {

        }
    }
}
