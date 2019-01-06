using System;

namespace Task_4
{
    class Program
    {
        static void Otric(int operand)
        {
            //Битовая операция сдвига влево
            operand = operand >> 31;
            if (operand == -1)
            {
                Console.WriteLine("Число отрицательное");
            }
            else
            {
                Console.WriteLine("Число положительное");
            }
        }

        static void Remainder(int operand)
        {
            //Проверка числа на возможность деления без остатка на 2, 5, 3, 6, 9 с помощью условного оператора.
            if ((operand % 2) == 0 && (operand % 5) == 0 && (operand % 3) == 0 && (operand % 6) == 0 && (operand % 9) == 0)
            {
                Console.WriteLine("Число делиться без остатка на 2, 5, 3, 6, 9");
            }
            else
            {
                Console.WriteLine("Число не делиться без остатка на 2, 5, 3, 6, 9");
            }
        }

        static void Simple(int operand)
        {
            int divider=2;   // Делитель.
            int remainder; // Остаток от деления operand на divider.

            do
            {
                //Запись остатка от деления в переменную remainder
                remainder = operand % divider;

                //Если число разделилось на делитель с остатком, увеличиваем делитель
                if (remainder != 0)
                    divider++;
            }
            while (remainder != 0); // Пока в результате деления остается остача

            if (divider == operand)
            {
                Console.WriteLine("{0} - простое число", operand);
            }
            else
            {
                Console.WriteLine("{0} - не простое число", operand);
            }
        }

        static void Main()
        {
            Console.Write("Введите число для проверки: ");
            int operand = Convert.ToInt32(Console.ReadLine());

            //Вызов методов для проверки числа на соответствие указанным требованиям.
            Simple(operand);
            Otric(operand);
            Remainder(operand);

            // Delay.
            Console.ReadKey();
        }
    }
}
