using System;

namespace Task_2
{
    class Program
    {
        static int Factorial(int n)
        {
            if (n == 0)
                return 1;
            else
                //Вызов метода из своего же тела (простая рекурсия)
                return n * Factorial(n - 1);
        }

        static void Main()
        {
            Console.WriteLine("Введите количество клиентов");
            int operand = Convert.ToInt32(Console.ReadLine());

            //Создание переменной целого типа и инициализация возвращаемым значением из метода Factorial.
            int factorial = Factorial(operand);

            Console.WriteLine("Количество маршрутов составит {0}", factorial);

            // Delay.
            Console.ReadKey();
        }
    }
}