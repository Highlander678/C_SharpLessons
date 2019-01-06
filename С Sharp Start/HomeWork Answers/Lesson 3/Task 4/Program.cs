using System;

namespace Task_4
{
    class Program
    {
        static void Main()
        {
            //Создание и инициализация переменных
            const float pi = 3.141f;
            int r = 15, // радиус
                h = 14; // высота

            //Отображение результата выражения π*R^2*h. 
            Console.WriteLine("Объем цилиндра {0}", (pi * r * r * h));

            //Отображение результата выражения  2*π*R^2 + 2*π*R^2 = 2*π*R*(R+ h) 
            Console.WriteLine("Площадь поверхности цилиндра {0}", (2 * pi * r * (r + h)));

            // Delay.
            Console.ReadKey();
        }
    }
}
