using System;

// Наследование.

namespace Inheritance
{
    class Program
    {
        static void Main()
        {
            DerivedClass instance = new DerivedClass(1, 2);

            Console.WriteLine(instance.Basenumber);
            Console.WriteLine(instance.derivedField);

            // Delay.
            Console.ReadKey();
        }
    }
}
