using System;

namespace Lessons_6
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите первое число:");
            int x = Convert.ToInt32(Console.ReadLine()); //Считывание информации введенной из клавиатуры, и конвертирование ее в int

            Console.WriteLine("Введите второе число:");
            int y = Convert.ToInt32(Console.ReadLine());

            //Использование цикла со счетчиком
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
