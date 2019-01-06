using System;

namespace Lessons_3
{
    class Printer
    {
        protected ConsoleColor color; //доступ к элементу можно получить только из кода 
                                      //в этом классе, либо в производном классе

        //Пользовательский контруктор
        public Printer(ConsoleColor color)
        {
            //Инициализация поля класса
            this.color = color;
        }

        public virtual void Print(string value) //Ключевое слово virtual используется для разрешения переопределения в производном классе
        {
            Console.ForegroundColor = color; //Задает цвет текста консоли.
            Console.WriteLine(value);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
