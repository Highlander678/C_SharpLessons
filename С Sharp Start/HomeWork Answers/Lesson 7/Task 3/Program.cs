using System;

namespace Task_3
{
    class Program
    {
        static double Converter(double currency, double course)
        {
            /*То же, что
             double rez = 0;
             rez = currency * course;
             return rez;  */

            return currency * course;
        }

        static void Main()
        {
            Console.Write("Введите сумму денег для конвертации: ");
            double currency = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите курс валюты для конвертации: ");
            double course = Convert.ToDouble(Console.ReadLine());

            //Вызов метода Converter внутри метода Console.WriteLine и передача ему двух аргументов
            //(суму денег и курс валюты).
            Console.WriteLine("Перевод суммы денег {0} по курсу {1} в сумму {2}",
                currency, course, Converter(currency, course));

            // Delay.
            Console.ReadKey();
        }
    }
}
