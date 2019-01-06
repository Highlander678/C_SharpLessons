using System;


namespace Lessons_17
{
    class Calculator
    {
        public dynamic Add(dynamic operand1, dynamic operand2)//Метод сложения динамических значений принятых в качестве параметров
        {
            return operand1 + operand2;
        }

        public dynamic Sub(dynamic operand1, dynamic operand2)//Метод вычитания динамических значений принятых в качестве параметров
        {
            return operand1 - operand2;
        }

        public dynamic Mul(dynamic operand1, dynamic operand2)//Метод умножения динамических значений принятых в качестве параметров
        {
            return operand1 * operand2;
        }

        public dynamic Div(dynamic operand1, dynamic operand2)//Метод деления динамических значений принятых в качестве параметров
        {
            if (operand2 != 0) //Если делитель не равен нулю
            {
                return operand1 / operand2; //Возвращаем результат деления
            }
            else
            {
                return "На 0 делить нельзя.";
            }

        }
    }

    class Program
    {
        static void Main()
        {
            Calculator calculator = new Calculator(); //Создание экземпляра класса Calculator
            int operand1 = 20, operand2 = 13; //Создание двух локальных переменных целого типа

            Console.WriteLine("{0} + {1} = {2}", operand1, operand2, calculator.Add(operand1, operand2)); //Отображение результата выполнения арифметической операции
            Console.WriteLine("{0} - {1} = {2}", operand1, operand2, calculator.Sub(operand1, operand2));
            Console.WriteLine("{0} * {1} = {2}", operand1, operand2, calculator.Mul(operand1, operand2));
            Console.WriteLine("{0} / {1} = {2}", operand1, operand2, calculator.Div(operand1, operand2));

            // Delay.
            Console.ReadKey();
        }
    }
}
