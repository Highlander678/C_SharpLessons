using System;

// Nested classes.

namespace Nested
{
    class MyClass
    {
        private static int field = 0;
        public int Parametr
        {
            get
            {
                return field;
            }
        }
        public class Nested
        {
            public void Method(int a)
            {
                field = a;

                Console.WriteLine(field);
            }
        }
    }

    class Program
    {
        static void Main()
        {
            MyClass.Nested instance = new MyClass.Nested();

            instance.Method(3);
            Console.WriteLine("Значение поля field = "+ MyClass.Parametr);
            // Delay.
            Console.ReadKey();
        }
    }
}
