using System;

// Статический конструктор.

namespace Static
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(NotStaticClass.ReadonlyField);

            // Delay.
            Console.ReadKey();
        }
    }
}
