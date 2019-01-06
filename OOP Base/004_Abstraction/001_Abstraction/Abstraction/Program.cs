using System;

// Абстрактный класс.

namespace Abstraction
{
    // Абстрактный класс.
    abstract class AbstractClass
    {
        public abstract void Method();
    }

    // Конкретный класс.
    class ConcreteClass : AbstractClass
    {
        public override void Method()
        {
            Console.WriteLine("Implementation");
        }
    }

    class Program
    {
        static void Main()
        {
            ConcreteClass instance = new ConcreteClass();

            instance.Method();
            AbstractClass instance1 = instance as AbstractClass;
            instance1.Method();


            // Delay.
            Console.ReadKey();
        }
    }
}
