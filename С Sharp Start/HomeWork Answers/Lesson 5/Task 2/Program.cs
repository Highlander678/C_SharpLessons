using System;

namespace Task_2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите число для проверки:");
            //Создание переменной типа byte и инициализация его значением, которое ввел пользователь, конвертируемым в в byte.
            byte x = Convert.ToByte(Console.ReadLine());
            byte n = (byte)(x << 7);//логический сдвиг числа

            if (n == 0)
            {
                Console.WriteLine("Число четное");
            }
            else
            {
                Console.WriteLine("Число не четное");
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
