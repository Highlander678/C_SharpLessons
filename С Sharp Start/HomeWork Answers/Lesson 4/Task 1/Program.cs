using System;

namespace Task_1
{
    class Program
    {
        static void Main()
        {
            //Множественное создание переменных  
            int operand1 = 10, operand2 = 4;
            //Запрос у пользователя входных данных
            Console.WriteLine("Введите знак арифметического действия:");
            //Считывание данных с клавиатуры
            string sing = Console.ReadLine();

            switch (sing) // sing - выражение-селектор
            {
                //Если постоянное значение case, соответствует значению выражения селектора оператора switch выполняется тело оператора case. 
                case "+": Console.WriteLine("{0} + {1} = {2}", operand1, operand2, operand1 + operand2);
                    break;
                case "-": Console.WriteLine("{0} - {1} = {2}", operand1, operand2, operand1 - operand2);
                    break;
                case "*": Console.WriteLine("{0} * {1} = {2}", operand1, operand2, operand1 * operand2);
                    break;
                case "/":
                    if (operand2 != 0)
                    {
                        //Отображение результата деления чисел
                        Console.WriteLine("{0} / {1} = {2}", operand1, operand2, operand1 / operand2);
                    }
                    else
                    {
                        Console.WriteLine("На 0 делить нельзя!");
                    }
                    break;
                //Выполняется в случае, когда нету подходящего постоянного выражения.
                default:
                    Console.WriteLine("Вы ввели знак не арифметической операции!");
                    break;
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
