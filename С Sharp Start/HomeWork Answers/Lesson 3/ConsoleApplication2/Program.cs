using System;

namespace Task2
{
    class Program
    {
        static void Main()
        {
            //Создание и инициализация переменных.
            double x = 10, y = 15, z = 20, rez = 0;
            //Вычисление среднего арифметического трех целочисленных значений. 
            rez = (x + y + z) / 3;

            //А если без скобок? 
            //rez = x + y + z / 3;

            //Отображение результата вычисления.
            Console.WriteLine("Среднее арифметическое чисел {0}, {1} и {2} равно {3}", x, y, z, rez);

            // Delay.
            Console.ReadKey();
        }
    }
}
