using System;

// Статические члены в нестатических классах.

namespace Static
{
    class Program
    {
        static void Main()
        {
            NotStaticClass instance = new NotStaticClass(1);


            NotStaticClass.Method();

            // Delay.
            Console.ReadKey();
        }
    }
}
