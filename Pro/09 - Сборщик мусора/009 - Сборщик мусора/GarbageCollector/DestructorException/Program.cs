using System;

// Необработанное исключение в деструкторе,
// приводит к остановке его работы.

namespace DestructorException
{
    class MyClass
    {
        ~ MyClass()
        {
            throw new Exception();

            Console.WriteLine("Succeeded!");
        }
    }

    class Program
    {
        static void Main()
        {
            MyClass my = new MyClass();
        }
    }
}
