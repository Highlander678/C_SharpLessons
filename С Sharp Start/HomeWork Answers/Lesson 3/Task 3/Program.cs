using System;

namespace Task_3
{
    class Program
    {
        static void Main()
        {
            //Создание константы
            const float pi = 3.141f;

            //А если без суфикса?
            //const float pi = 3.141;

            //Создание и инициализация целочисленной переменной
            int r = 15;

            //Отображение результата умножения значений переменных pi и r в квадрате.
            Console.WriteLine("Площадь круга {0}", (float)(pi * r * r));

            // Delay.
            Console.ReadKey();
        }
    }
}
