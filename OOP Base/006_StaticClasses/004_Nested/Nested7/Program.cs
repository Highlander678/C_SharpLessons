using System;

// Nested classes.

// Нестатические классы могут в себе содержать статические Nested классы.

namespace Nested
{
    public class MyClass
    {
        public static class Nested
        {
            public static void StaticMethodFromNested()
            {
                Console.WriteLine("Статический метод Nested класса.");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            MyClass.Nested.StaticMethodFromNested();

            // Delay.
            Console.ReadKey();
        }
    }
}
