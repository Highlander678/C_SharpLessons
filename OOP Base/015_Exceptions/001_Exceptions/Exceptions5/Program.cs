﻿using System;

// Обработка исключений.

namespace Exceptions
{
    // Для создания пользовательского исключения, требуется наследование от System.Exception.
    class UserException : Exception
    {
        public void Method()
        {
            Console.WriteLine("Мое Исключение!");
        }
    }

    class Program
    {
        static void Main()
        {
            try
            {
                throw new UserException();
            }
            catch (UserException e)
            {
                Console.WriteLine("Обработка исключения.");
                e.Method();
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
