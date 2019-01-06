using System;

// Цикл for вложенный в цикл for. ( Построение квадрата из звездочек - * )

namespace Loop
{
    class Program
    {
        static void Main()
        {

            for (int i = 0; i < 10; i++)
            {
                // Выводим одну строку из 10 звездочек.
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }

                // Переход на новую строку.
                Console.WriteLine();
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
