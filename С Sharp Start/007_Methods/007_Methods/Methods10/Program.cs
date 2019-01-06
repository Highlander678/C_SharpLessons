using System;

// Методы с выходными параметрами (out).

namespace Methods
{
    class Program
    {
        static int Method(out int a)
        {
            // Выходные параметры должны быть изменены в теле метода, иначе будет ошибка.
            a = 2;
            return a * 2;
        }

        static void Main()
        {
            int operand;

            // out - позволяет передавать в метод непроинициализированные переменные.
            
            int result = Method(out operand);

            Console.WriteLine("{0}; {1};", operand, result);

            // Delay.
            Console.ReadKey();
        }
    }
}
