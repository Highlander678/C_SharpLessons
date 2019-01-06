using System;

namespace Task_3
{
    class Author
    {
        //Если объявление поля содержит модификатор readonly,
        //присвоение значений таким полям может происходить только как часть объявления или в конструкторе в том же классе. 
        readonly string name;
            
        public Author(string name)
        {
            //Присвоение полю name класса Author значения аргумента переданного в конструктор
            this.name = name;
        }

        //Метод предназначен для отображения значения name
        public void Show()
        {
            //Задает цвет текста консоли.
            Console.ForegroundColor = ConsoleColor.Green;
            //Запись в стандартный выходной поток
            Console.WriteLine("Author: " + name);
        }
    }
}
