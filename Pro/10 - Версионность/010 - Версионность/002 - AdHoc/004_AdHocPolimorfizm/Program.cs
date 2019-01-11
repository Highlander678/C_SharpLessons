using System;

namespace AdHocPolimorfizm
{
    class Program
    {
        static void Main()
        {
            object[] array = { new Class1(), new Class2(), new Class3() };

            foreach (AbsBaseClass item in array)
            {
                item.AbsMeth();
                item.VirtMeth();
                item.SimpleMeth();

                Console.WriteLine("Поле: " + item.field);
                Console.WriteLine("Простое Свойство: " + item.MyProperty);
                Console.WriteLine("Абстрактное Свойство: " + item.AbsProp);
                Console.WriteLine("Виртуальное Свойство: " + item.VirtualProp);
                Console.WriteLine(new string('_', 55));
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
