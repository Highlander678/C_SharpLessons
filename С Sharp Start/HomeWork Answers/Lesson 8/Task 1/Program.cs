using System;

namespace Task_1
{
    class Program
    {   
        /// <summary>
        /// Вычисление задолженности
        /// </summary>
        /// <param name="operand">Принимает сумму для оплаты долга</param>
        static void Debt(ref int operand)
        {
            if (operand == 700)
            {
                Console.WriteLine("Долг погашен.");
            }
            else if (operand < 700)
            {
                Console.WriteLine("Задолженость составляет {0} у.е.", operand - 700);
            }
            else
            {
                Console.WriteLine("Долг погашен.");
                Console.WriteLine("Переплата составляет {0} у.е.", operand - 700);
            }
        }

        static void Main()
        {
            Console.WriteLine("Ваш долг составляет 700 у.е. ");
            Console.Write("Введите сумму для оплаты долга: ");
            int operand = Convert.ToInt32(Console.ReadLine());

            //Вызов метода Debt с аргументом operand который передается по ссылке
            Debt(ref operand);

            // Delay.
            Console.ReadKey();
        }
    }
}
