using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            //Создание и инициализация переменной “pi”.
            double pi = 3.141592653d;
            //Создание и инициализация переменной “e”.
            decimal e = 2.7182818284590452m;

            //Отображение сообщения "Число Pi равно: ".
            Console.Write("Число Pi равно: ");
            //Отображение значения переменной "pi".
            Console.WriteLine(pi);

            //Отображение сообщения "Число (Ейлера) e равно: ".
            Console.Write("Число (Ейлера) e равно: ");
            //Отображение значения переменной "e".
            Console.WriteLine(e);

            // Delay.
            Console.ReadKey();
        }
    }
}
