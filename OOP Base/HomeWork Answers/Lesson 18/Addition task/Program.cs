using System;

using MyNamespaceA; //Подключение пространства имен MyNamespaceA

namespace MyNamespaceB
{
    class Program
    {
        static void Main()
        {
            MyClass my = new MyClass(); //Инициализируем класс который описан в пространстве имен MyNamespaceA

            // Delay.
            Console.ReadKey();
        }
    }
}
