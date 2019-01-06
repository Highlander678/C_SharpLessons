using System;

namespace Lessons_4
{
    class Title : Part
    {
        public override string Content //Переопределение метода из абстрактного класса 
        {
            get
            {
                if (content != null)
                    return content;
                else 
                    return "Тело документа отсутствует.";
            }
            set
            {
                content = value;
            }
        }

        public override void Show() //Метод предназначеный для отображения результата
        {
            Console.ForegroundColor = ConsoleColor.Blue; //Задание цвета текста консоли
            Console.WriteLine(Content); //отображение значения переменной Content
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
