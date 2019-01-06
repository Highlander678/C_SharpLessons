using System;

namespace Task_2
{
    class Program
    {
        //метод сложения.
        static int Add(int operand1, int operand2)
        {
            return operand1 + operand2;
        }
        
        //метод вычитания.
        static int Sub(int operand1, int operand2)
        {
            return operand1 - operand2;
        }

        //метод умножения.
        static int Mul(int operand1, int operand2)
        {
            return operand1 * operand2;
        }

        //метод деления
        static int Div(int operand1, int operand2)
        {
            //Проверка возможности деления
            if (operand2 != 0)
            {
                return operand1 / operand2;
            }
            //Если пользователь заполнил делитель нулем, сообщаем ему об этом.
            else
            {
                Console.WriteLine("Деление на 0");
                return 0;
            }
        }

        static void Main()
        {
            //Запрос у пользователя входных данных
            Console.WriteLine("Введите 1 число:");
            int operand1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите 2 число:");
            int operand2 = Convert.ToInt32(Console.ReadLine());

            //Запрос у пользователя, какое действие он желает выполнить над введенными числами.
            Console.WriteLine("Введите знак арифметической операции: + - * /");
            string sing = Console.ReadLine();

            //Переключатель switch определяет ветвь по значению переданным в переменной sing.
            switch (sing)
            {
                case "+": Console.WriteLine("Сложение {0}", Add(operand1, operand2));
                    break;
                case "-": Console.WriteLine("Вычитание {0}", Sub(operand1, operand2));
                    break;
                case "*": Console.WriteLine("Умножение {0}", Mul(operand1, operand2));
                    break;
                case "/": Console.WriteLine("Деление {0}", Div(operand1, operand2));
                    break;
                //Выполнится, если ни один из операторов выбора case не содержит нужного значения.
                default:
                    Console.WriteLine("Вы ввели неверный знак");
                    break;
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
