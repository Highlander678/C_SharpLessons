using System;

// Прототип, (Prototype) — шаблон проектирования, порождающий объекты.

namespace Prototype
{
    class Program
    {
        static void Main()
        {
            // Создание двух экземпляров и клонирование их.
            ConcretePrototype1 p1 = new ConcretePrototype1("1");
            ConcretePrototype1 c1 = p1.Clone() as ConcretePrototype1;
            Console.WriteLine("Cloned: {0}", c1.Id);

            ConcretePrototype2 p2 = new ConcretePrototype2("2");
            ConcretePrototype2 c2 = p2.Clone() as ConcretePrototype2;
            Console.WriteLine("Cloned: {0}", c2.Id);

            // Задержка.
            Console.ReadKey();
        }
    }
}
