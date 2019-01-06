using System;

// Базовый класс Object.

namespace ClassObject
{
    class MyClass
    {
        public override string ToString()
        {
            return "Hello world!";
        }
    }

    class Program
    {
        static void Main()
        {
            MyClass instance = new MyClass();

            Console.WriteLine(instance.ToString());

            // Delay.
            Console.ReadKey();
        }
    }
}
