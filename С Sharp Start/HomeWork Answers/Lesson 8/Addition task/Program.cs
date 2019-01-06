using System;

namespace Lessons_8
{
    class Program
    {
        static void Calculate(ref double operand1, ref double operand2, ref double operand3)
        {
            /*Так как в метод аргументы переданы по ссылке, то все изменения в методе будут происходить с оригиналами*/
            operand1 /= 5;
            operand2 /= 5;
            operand3 /= 5;
        }

        static void Main()
        {
            double operand1 = 12, operand2 = 13, operand3 = 14;
            Console.WriteLine("Числа {0} {1} {2}", operand1, operand2, operand3);

            //Вызов метода Calculate и передача аргументов в метод по ссылке с помощью ключевого слова ref
            Calculate(ref operand1, ref operand2, ref operand3);
            Console.WriteLine("Числа {0} {1} {2}", operand1, operand2, operand3);

            // Delay.
            Console.ReadKey();
        }
    }
}
