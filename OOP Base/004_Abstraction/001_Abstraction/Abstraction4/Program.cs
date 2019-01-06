using System;

namespace Abstraction
{
    class Program
    {
        static void Main()
        {
            ConcreteDerivedClass instance = new ConcreteDerivedClass();

            instance.SimpleMethod();
            instance.VirtualMethod();
            instance.AbstractMethod();

            AbstractBaseClass inst = instance as AbstractBaseClass;
            inst.VirtualMethod();
            //Delay.
            Console.ReadKey();
        }
    }
}
