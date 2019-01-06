using System;

namespace Print
{
    enum Colors //создание перечисления целого типа
    {
        Blue = 0,
        Red = 1,
        Green = 2
    }

    static class MyClass
    {
        public static void Print(string line, int color) //Статический метод принимающий 2 аргумента
        {
            switch (color) //оператор многозначного выбора
            {
                case (int)Colors.Blue:
                    Console.ForegroundColor = ConsoleColor.Blue; //Установка цвета консоли
                    break;
                case (int)Colors.Green:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case (int)Colors.Red:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                default: 
                    Console.WriteLine("Введенная Вами строка будет выведена на экран цветом по умолчанию!");
                    break;
            }

            Console.WriteLine(line); //Отображение значения переменной line
        }
    }

    class Program
    {
        static void Main() //Точка входа программы
        {
            Console.WriteLine("Введите строку:");
            string line = Console.ReadLine(); //Считывание данных введенных пользователем

            Console.WriteLine("Укажите цвет: ( 0-blue, 2-green, 1-red)");
            int color = Convert.ToInt32(Console.ReadLine());

            MyClass.Print(line, color); //Вызов статического метода Print класса MyClass

            // Delay.
            Console.ReadKey();
        }
    }
}