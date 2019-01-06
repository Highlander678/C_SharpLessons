using System;

namespace Lesson_3
{
    class Program
    {
        static void Main()
        {
            //Создание переменных челого типа, а также инициализация переменных значениями 10 и 4 соответсвенно.
            //прием множественного обьявления
            int operand1 = 10, operand2 = 4;

            /*Вывод на консоль результата сложения значений переменных operand1 и operand2 с использованием маркера подстановки.
            В {0} подставится значение переменной operand1
            в {1} - значение переменной operand2,
            а в {2} – результат сложения.*/
            Console.WriteLine("{0} + {1} = {2}", operand1, operand2, operand1 + operand2);

            //Вывод на консоль результата вычитания значений переменных operand1 и operand2.
            Console.WriteLine("{0} - {1} = {2}", operand1, operand2, operand1 - operand2);

            //Вывод на консоль результата умножения значений переменных operand1 и operand2.
            Console.WriteLine("{0} * {1} = {2}", operand1, operand2, operand1 * operand2);

            //Вывод на консоль результата деления значений переменных operand1 и operand2.
            Console.WriteLine("{0} / {1} = {2}", operand1, operand2, operand1 / operand2);

            // Delay.
            Console.ReadKey();
        }
    }
}
