﻿using System;

// Константы.

namespace Static
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("e = {0}", NotStaticClass.e);

            // Delay.
            Console.ReadKey();
        }
    }
}
