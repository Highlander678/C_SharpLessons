﻿using System;

// Обработка исключений.

namespace Exceptions
{
    class Program
    {
        static void Main()
        {
            int a = 1, n = 2;

            try
            {
                // Попытка деления на ноль.
                a = a / (2 - n);

                Console.WriteLine("a = {0}", a);
            }
            catch (Exception e)
            {
                Console.WriteLine("Обработка исключения.");
                Console.WriteLine(e.Message);
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
