using System;

namespace Task_3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите первое число:");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            int y = Convert.ToInt32(Console.ReadLine());

            int z = 1;

            // Прямоугольник.
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // Прямоугольный треугольник.
            //По вертикали
            for (int i = 0; i < x; i++)
            {
                //По горизонтали
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            int buf = y;

            // Равносторонний треугольник.
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    //Отступ от края консоли
                    Console.Write(" ");
                }
                for (int k = 0; k < z; k++)
                {
                    Console.Write("*");
                }
                //Уменьшение значения отступа от левого края консоли
                y -= 1;
                //Увеличиваем количество звездочек на 2
                z += 2;
                Console.WriteLine();
            }
            Console.WriteLine();
            z = 1;

            // Ромб.
            for (int i = 0; i < (x+x+1); i++)
            {
                if (i<x)
                {
                    for (int j = 0; j < buf; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 0; k < z; k++)
                    {
                        Console.Write("*");
                    }
                    //Уменьшение значения отступа от левого края консоли
                    buf -= 1;
                    //Увеличиваем количество звездочек на 2
                    z += 2;
                    Console.WriteLine();
                }
                else
                {
                    for (int j = 0; j < buf; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 0; k < z; k++)
                    {
                        Console.Write("*");
                    }
                    //Увеличение значения отступа от левого края консоли
                    buf += 1;
                    //Уменьшение количество звездочек на 2
                    z -= 2;
                    Console.WriteLine();
                }
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
