using System;

// Индексаторы (переопределение).

namespace Indexers
{
    class Program
    {
        static void Main()
        {
            DerivedClass instance = new DerivedClass();
            BaseClass instance1 = instance;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(instance1[i]);
            }
            Console.WriteLine("Хэш для instance = "+instance.GetHashCode()+ " Хэш для instance1 = "+instance1.GetHashCode());
            // Delay.
            Console.ReadKey();
        }
    }
}
