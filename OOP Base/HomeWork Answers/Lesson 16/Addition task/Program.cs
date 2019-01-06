using System;

namespace Lessons_16
{
    class Program
    {
        static void Main()
        {

            Point a = new Point(1, 1, 1); //Создание экземпляра класса Point и инициализация пользовательским конструктором, в который передаем 3 аргумента(координаты точки)
            Point b = new Point(2, 2, 2);

            Point c = a + b; //Выполнение операции сложения на экземплярах класса Point

            Console.WriteLine("Координаты точки с равны "+c.X+" "+c.Y+" "+c.Z); //Отображаем результат выполнения переопределенной операции сложения

            // Delay.
            Console.ReadKey();
        }
    }
}
