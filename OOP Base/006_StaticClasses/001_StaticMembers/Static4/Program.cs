using System;

// Статические члены в нестатических классах.

namespace Static
{
    class Program
    {
        static void Main()
        {
            NotStaticClass.Property = 1;
            Console.WriteLine(NotStaticClass.Property);
            
            // Delay.
            Console.ReadKey();
        }
    }
}
