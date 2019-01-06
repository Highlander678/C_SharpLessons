using System;

// Нахождение факториала числа.

namespace MethodsRecFact
{

    class Program
    {
        static int Factorial(int n)
        {
            if (n == 0)
                return 1;
            else 
                return n * Factorial(n - 1);
        }
        
        static void Main()
        {            
            int factorial = Factorial(4);

            Console.WriteLine(factorial);

            // Задержка.
            Console.ReadKey();
        }
    }
}
