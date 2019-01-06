﻿using System;

// Сравнение элементов перечисления

namespace Enums
{
    class Program
    {
        static void Main()
        {  
            EnumType x = EnumType.Five;
            EnumType y = EnumType.One;
            EnumType.One = (byte)11;

            //if (x < y)                      // Первый вариант сравнения.
            if (EnumType.Five < EnumType.One) // Второй вариант сравнения.
                Console.WriteLine("X = {0} (меньше чем) Y = {1}.", x, y);
            else
                Console.WriteLine("Y = {0} (меньше чем) X = {1}.", y, x);

            // Delay.
            Console.ReadKey();
        }
    }
}
