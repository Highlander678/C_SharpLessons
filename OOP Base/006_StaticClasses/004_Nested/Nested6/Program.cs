using System;

// Nested classes.

// Статические классы могут в себе содержать нестатические Nested классы.

namespace Nested
{
    public static class MyClass
    {
        static MyClass()
        {
            Console.WriteLine("Статический конструктор MyClass");
        }

        public static void StaticMethod()
        {
            Console.WriteLine("Статический метод класса MyClass");
        }

        public class Nested
        {
            public void MethodFromNested()
            {
                Console.WriteLine("Метод Nested класса.");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            MyClass.Nested instance = new MyClass.Nested();
            instance.MethodFromNested();

            Console.WriteLine(new string('-', 30));

            MyClass.StaticMethod();

            // Delay.
            Console.ReadKey();
        }
    }
}
