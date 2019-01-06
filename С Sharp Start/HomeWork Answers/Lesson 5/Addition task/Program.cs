using System;

namespace AdditionTask
{
    class Program
    {
        static void Main()
        {
            int s = 0;
            Console.WriteLine("Введите число для проверки:");
            int x = Convert.ToInt32(Console.ReadLine());

            /*Ниже представлен алгоритм определения является ли число степенью двойки. 
             Например: пользователь ввел число 8, в битовом варианте выглядит так
              00001000  //8
             &
              00000111  //7
              --------
              00000000  //s = 0  */
            s = x & (x - 1);

            if (s == 0)
            {
                Console.WriteLine("Число являеться степенью двойки.");
            }
            else
            {
                Console.WriteLine("Число не являеться степенью двойки.");
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
