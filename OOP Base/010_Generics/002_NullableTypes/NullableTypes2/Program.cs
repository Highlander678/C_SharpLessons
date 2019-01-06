using System;

namespace NullableTypes
{
    class Program
    {
        static void Main()
        {
            // a - содержит неизвестное значение.
            int? a = null;
            int? b = -5; // b = -5

            // ѕри сравнении операндов один из которых = null - результатом сравнени€ всегда будет - false.
            // —ледовательно, нельз€ расчитывать на истинность (правильность) результата.       
            if (a >= b)
            {
                Console.WriteLine("a >= b");
            }
            else
            {
                Console.WriteLine("a < b");
            }

            // —равнивать операнды (Nullable) есть смысл только дл€ проверки - оба ли содержат null?
            // » если оба операнда содержат null, то результатом сравнени€ будет - true.

            b = null;

            if (a == b)
            {
                Console.WriteLine("a == b");
            }
            else
            {
                Console.WriteLine("a != b");
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
